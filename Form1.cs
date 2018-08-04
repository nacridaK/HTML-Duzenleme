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
        HtmlNode mesaj;
        public Form1()
        {
            InitializeComponent();
            comboBox_Tablo.SelectedIndex = 0;
        }
        private void button_VeriÇek_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument döküman = VeriyiGetir(textBox_MesajNumarası.Text);        
            mesaj = MesajıGetir(döküman, textBox_MesajNumarası.Text);
            try
            {
                foreach (HtmlNode satır in mesaj.SelectNodes("table/tbody/tr"))
                    oyuncuBindingSource.Add(new Oyuncu(satır));
                this.AcceptButton = button_PanoyaKopyala;
                button_PanoyaKopyala.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() +"\n\nSeçilen mesaj uygun değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_MesajNumarası.Focus();
            }
        }
        private void button_PanoyaKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mesaj.InnerHtml);
            MesajKutusuGöster(textBox_MesajNumarası.Text);
        }
        private void comboBox_Tablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_Maçlar.DataSource = oyuncuBindingSource;
        }
        private HtmlAgilityPack.HtmlDocument VeriyiGetir(string MesajNumarası)
        {
            WebClient client = new WebClient();
            HtmlAgilityPack.HtmlDocument döküman = new HtmlAgilityPack.HtmlDocument();
            döküman.LoadHtml(client.DownloadString("http://www.turkcespiker.com/forum/showpost.php?p=" + MesajNumarası));
            return döküman;
        }
        private HtmlNode MesajıGetir(HtmlAgilityPack.HtmlDocument Döküman, string MesajNumarası)
        {
            return Döküman.DocumentNode.SelectSingleNode("/html/body/form/table[2]/tr[2]/td[2]/div[2]");
        }
        private void MesajKutusuGöster(string MesajNumarası)
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
    }
}