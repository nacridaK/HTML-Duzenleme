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
            set => hücreler[3].InnerHtml = value;
        }
        public Oyuncu(HtmlNode satır)
        {
            hücreler = satır.SelectNodes("td");
        }
    }
}