using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;

namespace HTML_Veri_Çekme
{
    class Oyuncu
    {
        static HtmlNode tablo;
        public static void TabloAyarla(HtmlNode Tablo)
        {
            tablo = Tablo;
        }
        public static void OyuncuSil(int indis)
        {
            tablo.ChildNodes[indis].Remove();
        }
        HtmlNodeCollection hücreler;
        public string KullanıcıAdı
        {
            get => hücreler[0].InnerText;
            set => hücreler[0].InnerHtml = value;
        }
        public string SteamAdı
        {
            get => hücreler[1].InnerText;
            set => hücreler[1].InnerHtml = value;
        }
        public string PESAdı
        {
            get => hücreler[2].InnerText;
            set => hücreler[2].InnerHtml = value;
        }
        public string TakımAdı
        {
            get => hücreler[3].InnerText;
            set
            {
                hücreler[3].InnerHtml = value;
                //TakımArması = FTP'de takım armaları depolanacak.
            }
        }
        private string TakımArması;
        public Oyuncu(HtmlNode OyuncuSatır)
        {
            hücreler = OyuncuSatır.SelectNodes("td");
        }
        public Oyuncu()
        {
            tablo.InnerHtml += "<tr><td> </td><td> </td><td> </td><td> </td></tr>";
            hücreler = tablo.LastChild.SelectNodes("td");
            Console.WriteLine(tablo.ChildNodes.Count);
        }
    }
}