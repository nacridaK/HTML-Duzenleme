using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using HtmlAgilityPack;

namespace HTML_Veri_Çekme
{
    public partial class Form1 : Form
    {
        HtmlNode Mesaj;
        HtmlNode OyuncularTablosu;
        public Form1()
        {
            InitializeComponent();
            //comboBox_Tablo.SelectedIndex = 0;
        }
        private void button_VeriÇek_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument Döküman = VeriyiGetir(textBox_MesajNumarası.Text);        
            Mesaj = MesajıGetir(Döküman, textBox_MesajNumarası.Text);
            OyuncuTablosuSeçAyarla();
            button_VeriÇek.Enabled = false;
            textBox_MesajNumarası.Enabled = false;
            label_Mesaj.Enabled = false;
            button_PanoyaKopyala.Enabled = true;
            label_Tablo.Enabled = true;
            comboBox_Tablo.Enabled = true;
            this.AcceptButton = button_PanoyaKopyala;
        }
        private void button_PanoyaKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Mesaj.InnerHtml);
            ÇıkışOnayıGöster(textBox_MesajNumarası.Text);
        }
        private void comboBox_Tablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_Maçlar.DataSource = OyuncularBindingSource;
        }
        private HtmlAgilityPack.HtmlDocument VeriyiGetir(string MesajNumarası)
        {
            WebClient client = new WebClient();
            HtmlAgilityPack.HtmlDocument döküman = new HtmlAgilityPack.HtmlDocument();
            try
            {
                döküman.LoadHtml(client.DownloadString("http://www.turkcespiker.com/forum/showpost.php?p=" + MesajNumarası));
            }
            catch (Exception ex)
            {
                HataMesajıGöster("İnternet Hatası", ex);
            }
            return döküman;
        }
        private HtmlNode MesajıGetir(HtmlAgilityPack.HtmlDocument Döküman, string MesajNumarası)
        {
            return Döküman.DocumentNode.SelectSingleNode("/html/body/form/table[2]/tr[2]/td[2]/div[2]");
        }
        private void ÇıkışOnayıGöster(string MesajNumarası)
        {        
            switch (MessageBox.Show("HTML kodu panoya kaydedildi, düzenleme sayfası açılıp yazılım kapatılsın mı?", "Çıkış Onayı", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    Process.Start("http://www.turkcespiker.com/forum/editpost.php?do=editpost&p=" + MesajNumarası);
                    Application.Exit();
                    break;
                case DialogResult.No:
                    Application.Exit();
                    break;
            }
        }
        private void HataMesajıGöster(string Başlık, Exception ex)
        {
            MessageBox.Show(ex.ToString(), Başlık, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OyuncuTablosuSeçAyarla()
        {
            OyuncularTablosu = Mesaj.SelectSingleNode("table/tbody");
            Oyuncu.TabloAyarla(OyuncularTablosu);
            HtmlNodeCollection OyuncularSatırlar = OyuncularTablosu.SelectNodes("tr");
            try
            {
                foreach (HtmlNode OyuncuSatır in OyuncularSatırlar)
                    OyuncularBindingSource.Add(new Oyuncu(OyuncuSatır));

            }
            catch (Exception ex)
            {
                HataMesajıGöster("Oyuncu Tablosu Hatası", ex);
            }
        }
        private void oyuncuBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
                Oyuncu.OyuncuSil(e.NewIndex);
        }
    }
}