using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace HTML_Veri_Çekme
{
    class Oyuncu
    {
        public static HtmlNode OyuncuTablosu;
        public static List<Oyuncu> Liste = new List<Oyuncu>();
        HtmlNode OyuncuSatır;
        public static void OyuncuSil(int indis)
        {
            OyuncuTablosu.SelectNodes("tbody/tr[@id='OT_Satır']")[indis].RemoveAll();
        }
        public static void OyuncularıGüncelle(BindingSource Kaynak)
        {
            Liste.RemoveRange(0, Liste.Count);
            HtmlNodeCollection OyuncuSatırlar = OyuncuTablosu.SelectNodes("tbody/tr[@id='OT_Satır']");
            foreach (HtmlNode OyuncuSatır in OyuncuSatırlar)
                new Oyuncu(OyuncuSatır);
            Kaynak.DataSource = Oyuncu.Liste;
        }
        public string KullanıcıAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']").InnerText;
            set => OyuncuSatır.SelectSingleNode("td[@id='OT_Kullanıcı']").InnerHtml = value ?? "&nbsp;";
        }
        public string SteamAdı
        {
            get => OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']").InnerText;
            set => OyuncuSatır.SelectSingleNode("td[@id='OT_Steam']").InnerHtml = value ?? "&nbsp;";
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
                OyuncuSatır.SelectSingleNode("td[@id='OT_Takım']").InnerHtml = value ?? "&nbsp;";
                OyuncuSatır.SelectSingleNode("td[@id='OT_Arma']").FirstChild.SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/" + value + ".png" ?? "Belirsiz.png");
            }
        }
        private Oyuncu(HtmlNode OyuncuSatır)
        {
            this.OyuncuSatır = OyuncuSatır;
            Liste.Add(this);
        }
        public Oyuncu()
        {
            OyuncuTablosu.SelectSingleNode("tbody").InnerHtml += "<tr id=\"OT_Satır\"><td height=\"19\" align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_Kullanıcı\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_Steam\">&nbsp;</td><td bgcolor=\"#FFFFCC\" id=\"OT_PES\">&nbsp;</td><td align=\"center\" valign=\"middle\" bgcolor=\"#FFFFCC\" id=\"OT_Arma\"><img src=\"http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/Belirsiz.png\" height=\"18\"/></td><td bgcolor=\"#FFFFCC\" id=\"OT_Takım\">Belirsiz</td><td align=\"center\" bgcolor=\"#FFFFCC\" class=\"Gizli\">&nbsp;</td></tr>";
            OyuncuSatır = OyuncuTablosu.SelectSingleNode("tbody").LastChild;
        }
    }
}