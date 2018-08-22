using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace HTML_Veri_Çekme
{
    class Oyuncu
    {
        public static HtmlNode OyuncuTablosu;
        public static List<Oyuncu> Liste = new List<Oyuncu>();
        HtmlNode OyuncuSatır;
        static Dictionary<string, string> KullanıcılarSözlük;
        public static void OyuncuSil(int indis)
        {
            OyuncuTablosu.SelectNodes("tbody/tr[@id='OT_Satır']")[indis].RemoveAll();
        }
        public static void OyuncularıGüncelle(BindingSource Kaynak, Dictionary<string, string> Sözlük)
        {
            KullanıcılarSözlük = Sözlük;
            HtmlNodeCollection OyuncuSatırlar = OyuncuTablosu.SelectNodes("tbody/tr[@id='OT_Satır']");
            foreach (HtmlNode OyuncuSatır in OyuncuSatırlar)
                new Oyuncu(OyuncuSatır);
            Kaynak.DataSource = Oyuncu.Liste;
        }
        public string Rütbe
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']/a/span").GetAttributeValue("class","Üye");
            set => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']/a/span").SetAttributeValue("class", value);
        }
        public string KullanıcıAdıHTML
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']").InnerHtml;
        }
        public string KullanıcıAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']/a/span").InnerText;
            set
            {
                OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']/a").SetAttributeValue("href", "http://www.turkcespiker.com/forum/member.php?" + KullanıcılarSözlük[value]);
                OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']/a/span").InnerHtml = value ?? "&nbsp;";
            }
        }
        public string SteamAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']/a").InnerText;
            set
            {
                if (long.TryParse(value, out long Steam64ID))
                {
                    OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']/a").SetAttributeValue("href", "http://steamcommunity.com/profiles/" + Steam64ID);
                    OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']/a").InnerHtml = Form1.EtiketiGetir("http://steamcommunity.com/profiles/" + Steam64ID, "html/body/div[1]/div[7]/div[3]/div[1]/div[1]/div/div/div/div[1]/div[1]/span[1]").InnerText;
                }   
                else if (value != "&nbsp;")
                {
                    OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']/a").SetAttributeValue("href", value);
                    OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']/a").InnerHtml = Form1.EtiketiGetir(value, "html/body/div[1]/div[7]/div[3]/div[1]/div[1]/div/div/div/div[1]/div[1]/span[1]").InnerText;
                }
            }
        }
        public string PESAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_PES']").InnerText;
            set => OyuncuSatır.SelectSingleNode("td[@id='OT_PES']").InnerHtml = value ?? "&nbsp;";
        }
        public string TakımAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Takım']").InnerText;
            set
            {
                OyuncuSatır.SelectSingleNode("td[@id='OT_Takım']").InnerHtml = value ?? "Belirsiz";
                OyuncuSatır.SelectSingleNode("td[@id='OT_Arma']/img").SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/" + TakımAdı + ".png");
            }
        }
        private Oyuncu(HtmlNode OyuncuSatır)
        {
            this.OyuncuSatır = OyuncuSatır;
            Liste.Add(this);
        }
        public Oyuncu()
        {
            OyuncuTablosu.SelectSingleNode("tbody").InnerHtml += "<tr id=\"OT_Satır\"><td height=\"19\" align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_Kullanıcı\"><a><span class=\"Üye\">&nbsp;</span></a></td><td bgcolor=\"#FFFFCC\" id=\"OT_Steam\"><a>&nbsp;</a></td><td bgcolor=\"#FFFFCC\" id=\"OT_PES\">&nbsp;</td><td align=\"center\" valign=\"middle\" bgcolor=\"#FFFFCC\" id=\"OT_Arma\"><img src=\"http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/Belirsiz.png\" height=\"18\"/></td><td bgcolor=\"#FFFFCC\" id=\"OT_Takım\">Belirsiz</td><td align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td></tr>";
            OyuncuSatır = OyuncuTablosu.SelectSingleNode("tbody").LastChild;
        }
    }
}