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
using Microsoft.VisualBasic;

namespace HTML_Veri_Çekme
{
    public partial class Form1 : Form
    {
        HtmlNode Mesaj;
        HtmlNode MaçTablosu;
        HtmlNodeCollection GrupTabloları;
        GrupOyuncu[][] Gruplar;
        string SeçilenKullanıcı;
        bool HızlıÇıkış;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_VeriÇek_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument Döküman = VeriyiGetir(numericUpDown_Mesaj.Value);        
            Mesaj = MesajıGetir(Döküman, numericUpDown_Mesaj.Value);
            button_VeriÇek.Enabled = false;
            numericUpDown_Mesaj.Enabled = false;
            numericUpDown_Konu.Enabled = false;
            label_Mesaj.Enabled = false;
            button_PanoyaKopyala.Enabled = true;
            comboBox_Grup.Enabled = true;
            OyuncuTablosuAyarla();
            GrupTablolalarıAyarla();
            //MaçTablosuAyarla();
            this.AcceptButton = button_PanoyaKopyala;
        }
        private void button_PanoyaKopyala_Click(object sender, EventArgs e)
        {
            KoduTemizleVeDüzenle();
            Clipboard.SetText(Mesaj.InnerHtml);
            ÇıkışOnayıGöster(numericUpDown_Mesaj.Value);
        }
        private void button_OyuncuGüncelle_Click(object sender, EventArgs e)
        {
            GrupOyuncu EskiOyuncu = Gruplar[comboBox_Grup.SelectedIndex][dataGridView_Grup.SelectedRows[0].Index];
            Oyuncu YeniOyuncu = Oyuncu.Liste[dataGridView_Oyuncular.SelectedRows[0].Index];
            EskiOyuncu.OyuncuAdı = YeniOyuncu.KullanıcıAdı;
            EskiOyuncu.Arma = YeniOyuncu.TakımAdı;
        }
        private HtmlNode MesajıGetir(HtmlAgilityPack.HtmlDocument Döküman, decimal MesajNumarası)
        {
            return Döküman.DocumentNode.SelectSingleNode("/html/body/form/table[2]/tr[2]/td[2]/div[2]");
        }
        private void GrupTablolalarıAyarla()
        {
            GrupTabloları = Mesaj.SelectNodes("//table[@id='P_Tablosu']");
            Gruplar = new GrupOyuncu[GrupTabloları.Count][];
            for (int i = 0; i < GrupTabloları.Count; i++)
            {
                Gruplar[i] = GrupOyuncu.GrupOluştur(GrupTabloları[i]);
                comboBox_Grup.Items.Add((char)(i + 65) + " Grubu");
            }
        }
        private void comboBox_Grup_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource_Grup.DataSource = Gruplar[comboBox_Grup.SelectedIndex];
            button_OyuncuGüncelle.Enabled = true;
        }
        private void OyuncuTablosuAyarla()
        {
            Oyuncu.OyuncuTablosu = Mesaj.SelectSingleNode("//table[@id='O_Tablosu']");
            Oyuncu.OyuncularıGüncelle(bindingSource_Oyuncular);
            dataGridView_Oyuncular.DataSource = bindingSource_Oyuncular;
        }
        private void MaçTablosuAyarla()
        {
            while (Maç.Liste.Count != 0)
                Maç.Liste.RemoveAt(0);
            MaçTablosu = Mesaj.SelectSingleNode("table[2]/tbody");
            Maç.TabloAyarla(MaçTablosu);
            HtmlNodeCollection MaçSatırlar = MaçTablosu.SelectNodes("tr");
            try
            {
                foreach (HtmlNode MaçSatır in MaçSatırlar)
                    Maç.Liste.Add(new Maç(MaçSatır));
                //bindingSource_Maçlar.DataSource = Maç.Liste;
            }
            catch (Exception ex)
            {
                HataMesajıGöster("Maç Tablosu Hatası", ex);
            }
        }
        private void KoduTemizleVeDüzenle()
        {
            HtmlNodeCollection Copyright = Mesaj.SelectNodes("//span");
            if (Copyright != null)
                foreach (HtmlNode Etiket in Copyright)
                {
                    //Etiket.RemoveAll();
                }
            HtmlNodeCollection PreSpoiler = Mesaj.SelectNodes("//div[@class='pre-spoiler']");
            if (PreSpoiler != null)
                foreach (HtmlNode Etiket in PreSpoiler)
                {
                    Etiket.RemoveAll();
                    Etiket.Remove();
                }
            HtmlNodeCollection Spoiler = Mesaj.SelectNodes("//div[@class='içerige bak']");
            if (Spoiler != null)
                foreach (HtmlNode Etiket in Spoiler)
                {
                    Mesaj.InnerHtml = Mesaj.InnerHtml.Replace(Etiket.ParentNode.ParentNode.OuterHtml, "[GIZLI]" + Etiket.InnerHtml + "[/GIZLI]");
                }
            Mesaj.InnerHtml = Mesaj.InnerHtml.Replace("<br>", null);
            //Mesaj.InnerHtml = Mesaj.InnerHtml.Replace("<tr></tr>", null);
            //Mesaj.InnerHtml = Mesaj.InnerHtml.Replace("<td height=\"19\" align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_Kullanıcı\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_Steam\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_PES\">&nbsp;</td><td align=\"center\" valign=\"middle\" bgcolor=\"#FFFFCC\" id=\"OT_Arma\"><img src=\"http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/Belirsiz.png\" height=\"18\"/></td><td bgcolor=\"#FFFFCC\" id=\"OT_Takım\">Belirsiz</td><td align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td>", null);
        }
        private void dataGridView_Oyuncular_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView_Oyuncular.DataSource == bindingSource_Oyuncular && dataGridView_Oyuncular.CurrentCell.ColumnIndex == 0)
                SeçilenKullanıcı =  dataGridView_Oyuncular.CurrentCell.Value.ToString();
            Console.WriteLine("Düzenleme Başladı");
        }
        private void dataGridView_Oyuncular_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView_Maçlar.DataSource == bindingSource_Oyuncular && dataGridView_Maçlar.CurrentCell.ColumnIndex == 0 && SeçilenKullanıcı != " ")
            //    Maç.KullanıcıAdıDeğiştir(SeçilenKullanıcı, dataGridView_Maçlar.CurrentCell.Value.ToString());
        }
        private void bindingSource_Oyuncular_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
                Oyuncu.OyuncuSil(e.NewIndex);
        }
        private void dataGridView_Oyuncular_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = "&nbsp;";
            e.Row.Cells[1].Value = "&nbsp;";
            e.Row.Cells[2].Value = "&nbsp;";
            e.Row.Cells[3].Value = "Belirsiz";
        }
        private HtmlAgilityPack.HtmlDocument VeriyiGetir(decimal MesajNumarası)
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
        private void ÇıkışOnayıGöster(decimal MesajNumarası)
        {
            switch (MessageBox.Show("HTML kodu panoya kaydedildi, düzenleme sayfası açılıp yazılım kapatılsın mı?", "Çıkış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    Process.Start("http://www.turkcespiker.com/forum/editpost.php?do=editpost&p=" + MesajNumarası);
                    HızlıÇıkış = true;
                    Application.Exit();
                    break;
                case DialogResult.No:
                    HızlıÇıkış = true;
                    Application.Exit();
                    break;
            }
        }
        private void HataMesajıGöster(string Başlık, Exception ex)
        {
            MessageBox.Show(ex.ToString(), Başlık, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!HızlıÇıkış)
                if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
        }
    }
}