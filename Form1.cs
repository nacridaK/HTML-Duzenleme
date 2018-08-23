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
        HtmlNodeCollection GrupTabloları;
        HtmlNodeCollection MaçTabloları;
        GrupOyuncu[][] Gruplar;
        Maç[][] Maçlar;
        bool HızlıÇıkış;
        public static Dictionary<string, string> KullanıcılarSözlük = new Dictionary<string, string>();
        public static BindingSource Kaynak;
        public Form1()
        {
            InitializeComponent();
            Kaynak = bindingSource_Oyuncular;
        }
        private void button_VeriÇek_Click(object sender, EventArgs e)
        {
            Mesaj = EtiketiGetir("http://www.turkcespiker.com/forum/showpost.php?p=" + numericUpDown_Mesaj.Value, "html/body/form/table[2]/tr[2]/td[2]/div[2]");
            button_VeriÇek.Enabled = false;
            numericUpDown_Mesaj.Enabled = false;
            numericUpDown_Konu.Enabled = false;
            label_Mesaj.Enabled = false;
            label_Konu.Enabled = false;
            button_PanoyaKopyala.Enabled = true;
            toolStripLabel_Grup.Enabled = true;
            toolStripComboBox_Grup.Enabled = true;
            KullanıcılarıAyarla();
            TakımlarıAyarla();
            OyuncuTablosuAyarla();
            GrupTablolalarıAyarla();
            MaçTablosuAyarla();
            this.AcceptButton = button_PanoyaKopyala;
        }
        private void KullanıcılarıAyarla()
        {
            string[] Sınıflar = { "Üye", "Yetkili", "ÜYetkili", "Yönetici", "Spiker" };
            dataGridViewComboBoxColumn_Rütbe.DataSource = Sınıflar;
            HtmlNodeCollection Kullanıcılar = EtiketleriGetir("http://www.turkcespiker.com/forum/misc.php?do=whoposted&t=" + numericUpDown_Konu.Value, "html/body/table/tr");
            for (int i = 2; i < Kullanıcılar.Count - 1; i++)
            {
                HtmlNode Kullanıcı = Kullanıcılar[i].SelectSingleNode("td[1]/a");
                KullanıcılarSözlük.Add(Kullanıcı.InnerText, Kullanıcı.GetAttributeValue("href", null).Split(';')[1]);
            }
            KullanıcılarSözlük.Add("&nbsp;", "u=0");
            dataGridViewComboBoxColumn_KullanıcıAdı.DataSource = KullanıcılarSözlük.Keys.ToArray();
        }
        private void TakımlarıAyarla()
        {
            HtmlNodeCollection Takımlar = EtiketleriGetir("http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar", "html/body/pre//a");
            for (int i = 0; i < Takımlar.Count - 5; i++)
                dataGridViewComboBoxColumn_TakımAdı.Items.Add(Takımlar[i + 5].InnerText.Split('.')[0]);
        }
        private void button_PanoyaKopyala_Click(object sender, EventArgs e)
        {
            KoduTemizleVeDüzenle();
            Clipboard.SetText(Mesaj.InnerHtml);
            ÇıkışOnayıGöster(numericUpDown_Mesaj.Value);
        }
        private void SıralanmışGruplarıKaydet()
        {
            HtmlNodeCollection GrupSatırlar = GrupTabloları[toolStripComboBox_Grup.SelectedIndex].SelectNodes("tbody/tr[@id='PT_Satır']");
            GrupOyuncu[] Grup = Gruplar[toolStripComboBox_Grup.SelectedIndex];
            string[] Satırlar = new string[Grup.Length];
            for (int i = 0; i < Grup.Length; i++)
                Satırlar[i] = "<td align=\"center\" bgcolor=\"#00CC00\" id=\"PT_Sıra\"><strong>" + (i + 1) + "</strong></td><td width=\"35\" align=\"center\" bgcolor=\"#CCFFFF\" id=\"PT_Arma\"><img src=\"http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/" + Grup[i].Arma + ".png\" height=\"18\"/></td><td width=\"130\" bgcolor=\"#FFFFCC\" id=\"PT_Oyuncu\">" + Grup[i].OyuncuAdı + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_O\">" + Grup[i].OynananMaç + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_G\">" + Grup[i].GalibiyetSayısı + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_B\">" + Grup[i].BeraberlikSayısı + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_M\">" + Grup[i].MağlubiyetSayısı + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_A\">" + Grup[i].AtılanGol + "</td><td align=\"center\" bgcolor=\"#FFFFCC\" id=\"PT_Y\">" + Grup[i].YenenGol + "</td><td align=\"center\" bgcolor=\"#DDDDB2\" id=\"PT_AV\">" + Grup[i].Averaj + "</td><td align=\"center\" bgcolor=\"#DDDDB2\" id=\"PT_P\">" + Grup[i].Puan + "</td>";
            for (int i = 0; i < Grup.Length; i++)
                GrupSatırlar[i].InnerHtml = Satırlar[i];
        }
        private void toolStripButton_Sırala_Click(object sender, EventArgs e)
        {
            bindingSource_Grup.DataSource = null;
            Array.Sort(Gruplar[toolStripComboBox_Grup.SelectedIndex]);
            SıralanmışGruplarıKaydet();
            bindingSource_Grup.DataSource = Gruplar[toolStripComboBox_Grup.SelectedIndex];
        }
        private void toolStripButton_Güncelle_Click(object sender, EventArgs e)
        {
            GrupOyuncu EskiOyuncu = Gruplar[toolStripComboBox_Grup.SelectedIndex][dataGridView_Grup.SelectedRows[0].Index];
            //Oyuncu YeniOyuncu = Oyuncu.Liste[dataGridView_Oyuncular.SelectedRows[0].Index];
            Oyuncu YeniOyuncu = Oyuncu.Liste[dataGridView_Oyuncular.SelectedCells[0].RowIndex];
            for (int i = 0; i < Maçlar[toolStripComboBox_Grup.SelectedIndex].Length; i++)
            {
                if(Maçlar[toolStripComboBox_Grup.SelectedIndex][i].EvSahibi == EskiOyuncu.OyuncuAdı)
                {
                    Maçlar[toolStripComboBox_Grup.SelectedIndex][i].EvSahibi = YeniOyuncu.KullanıcıAdıHTML;
                    Maçlar[toolStripComboBox_Grup.SelectedIndex][i].EvSahibiArma = YeniOyuncu.TakımAdı;
                }
                else if (Maçlar[toolStripComboBox_Grup.SelectedIndex][i].Konuk == EskiOyuncu.OyuncuAdı)
                {
                    Maçlar[toolStripComboBox_Grup.SelectedIndex][i].Konuk = YeniOyuncu.KullanıcıAdıHTML;
                    Maçlar[toolStripComboBox_Grup.SelectedIndex][i].KonukArma = YeniOyuncu.TakımAdı;
                }
            }
            EskiOyuncu.OyuncuAdı = YeniOyuncu.KullanıcıAdıHTML;
            EskiOyuncu.Arma = YeniOyuncu.TakımAdı;
            bindingSource_Grup.DataSource = null;
            bindingSource_Maçlar.DataSource = null;
            bindingSource_Grup.DataSource = Gruplar[toolStripComboBox_Grup.SelectedIndex];
            bindingSource_Maçlar.DataSource = Maçlar[toolStripComboBox_Grup.SelectedIndex];
        }
        public static HtmlNode EtiketiGetir(string Adres, string XPath)
        {
            WebClient Client = new WebClient();
            HtmlAgilityPack.HtmlDocument Döküman = new HtmlAgilityPack.HtmlDocument();
            Döküman.LoadHtml(Client.DownloadString(Adres));
            return Döküman.DocumentNode.SelectSingleNode(XPath);
        }
        private HtmlNodeCollection EtiketleriGetir(string Adres, string XPath)
        {
            WebClient Client = new WebClient();
            HtmlAgilityPack.HtmlDocument Döküman = new HtmlAgilityPack.HtmlDocument();
            Döküman.LoadHtml(Client.DownloadString(Adres));
            return Döküman.DocumentNode.SelectNodes(XPath);
        }
        private void MaçTablosuAyarla()
        {
            MaçTabloları = Mesaj.SelectNodes("//table[@id='M_Tablosu']");
            Maçlar = new Maç[MaçTabloları.Count][];
            for (int i = 0; i < MaçTabloları.Count; i++)
                Maçlar[i] = Maç.MaçlarOluştur(MaçTabloları[i]);
        }
        private void GrupTablolalarıAyarla()
        {
            GrupTabloları = Mesaj.SelectNodes("//table[@id='P_Tablosu']");
            Gruplar = new GrupOyuncu[GrupTabloları.Count][];
            for (int i = 0; i < GrupTabloları.Count; i++)
            {
                Gruplar[i] = GrupOyuncu.GrupOluştur(GrupTabloları[i]);
                toolStripComboBox_Grup.Items.Add((char)(i + 65) + " Grubu");
            }
        }
        private void toolStripComboBox_Grup_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource_Grup.DataSource = Gruplar[toolStripComboBox_Grup.SelectedIndex];
            bindingSource_Maçlar.DataSource = Maçlar[toolStripComboBox_Grup.SelectedIndex];
            toolStripButton_Güncelle.Enabled = true;
            toolStripButton_Sırala.Enabled = true;
            toolStripButton_Kaydet.Enabled = true;
        }
        private void toolStripButton_Kaydet_Click(object sender, EventArgs e)
        {
            GrupOyuncu[] Grup = Gruplar[toolStripComboBox_Grup.SelectedIndex];
            Maç[] GrupMaçları = Maçlar[toolStripComboBox_Grup.SelectedIndex];
            GrupOyuncu.VerileriSıfırla(Grup);
            for (int i = 0; i < GrupMaçları.Length; i++)
            {
                Maç GrupMaçı = GrupMaçları[i];
                if (GrupMaçı.OynandıMı)
                {
                    GrupOyuncu EvSahibi = GrupOyuncu.OyuncuBul(Grup, GrupMaçı.EvSahibi);
                    GrupOyuncu Konuk = GrupOyuncu.OyuncuBul(Grup, GrupMaçı.Konuk);
                    EvSahibi.GolAttı(byte.Parse(GrupMaçı.EvSahibiGol));
                    EvSahibi.GolYedi(byte.Parse(GrupMaçı.KonukGol));
                    Konuk.GolAttı(byte.Parse(GrupMaçı.KonukGol));
                    Konuk.GolYedi(byte.Parse(GrupMaçı.EvSahibiGol));
                    switch (GrupMaçı.Sonuç)
                    {
                        case -1:
                            EvSahibi.Galibiyet();
                            Konuk.Mağlubiyet();
                            break;
                        case 0:
                            EvSahibi.Beraberlik();
                            Konuk.Beraberlik();
                            break;
                        case 1:
                            EvSahibi.Mağlubiyet();
                            Konuk.Galibiyet();
                            break;
                    }
                }
            }
            bindingSource_Grup.DataSource = null;
            bindingSource_Grup.DataSource = Gruplar[toolStripComboBox_Grup.SelectedIndex];
        }
        private void OyuncuTablosuAyarla()
        {
            Oyuncu.OyuncuTablosu = Mesaj.SelectSingleNode("//table[@id='O_Tablosu']");
            Oyuncu.OyuncularıGüncelle();
            dataGridView_Oyuncular.DataSource = bindingSource_Oyuncular;
            bindingSource_Oyuncular.AllowNew = true;
        }
        private void toolStripButton_Kontrol_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Oyuncu.Liste.Count);
            HtmlNodeCollection OyuncuSatırlar = Mesaj.SelectNodes("//table[@id='O_Tablosu']/tbody/tr[@id='OT_Satır']");
            foreach (HtmlNode OyuncuSatır in OyuncuSatırlar)
                Console.WriteLine(OyuncuSatır.InnerHtml);
            Console.WriteLine();
        }
        private void toolStripButton_Yenile_Click(object sender, EventArgs e)
        {
            bindingSource_Oyuncular.DataSource = null;
            bindingSource_Oyuncular.DataSource = Oyuncu.Liste;
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
        }
        private void dataGridView_Oyuncular_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (dataGridView_Oyuncular.DataSource == bindingSource_Oyuncular && dataGridView_Oyuncular.CurrentCell.ColumnIndex == 0)
            //    SeçilenKullanıcı =  dataGridView_Oyuncular.CurrentCell.Value.ToString();
        }
        private void dataGridView_Oyuncular_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView_Maçlar.DataSource == bindingSource_Oyuncular && dataGridView_Maçlar.CurrentCell.ColumnIndex == 0 && SeçilenKullanıcı != " ")
            //    Maç.KullanıcıAdıDeğiştir(SeçilenKullanıcı, dataGridView_Maçlar.CurrentCell.Value.ToString());
        }
        private void bindingSource_Oyuncular_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    Console.WriteLine("ItemAdded");
                    break;
                case ListChangedType.ItemChanged:
                    Console.WriteLine("ItemChanged");
                    break;
                case ListChangedType.ItemDeleted:
                    Console.WriteLine("ItemDeleted");
                    Oyuncu.OyuncuSil(e.NewIndex);
                    break;
            }
        }
        private void ÇıkışOnayıGöster(decimal MesajNumarası)
        {
            switch (MessageBox.Show("HTML kodu panoya kopyalandı, yazılım kapatıldıktan sonra düzenleme sayfası açılsın mı?", "Çıkış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
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