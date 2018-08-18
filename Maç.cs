using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTML_Veri_Çekme
{
    class Maç
    {
        public static List<Maç> Liste = new List<Maç>();
        static HtmlNode maçtablosu;
        public static void TabloAyarla(HtmlNode MaçTablosu)
        {
            maçtablosu = MaçTablosu;
        }
        public static void KullanıcıAdıDeğiştir(string EskiAd, string YeniAd)
        {
            maçtablosu.InnerHtml = maçtablosu.InnerHtml.Replace(EskiAd, YeniAd);
        }
        HtmlNodeCollection Hücreler;
        public string EvSahibiKullanıcı
        {
            get => Hücreler[1].InnerText;
        }
        public string EvSahibiGol
        {
            get => Hücreler[2].InnerText;
            set => Hücreler[2].InnerHtml = value;
        }
        public string KonukGol
        {
            get => Hücreler[3].InnerText;
            set => Hücreler[3].InnerHtml = value;
        }
        public string KonukKullanıcı
        {
            get => Hücreler[4].InnerText;
        }
        public Maç(HtmlNode MaçSatır)
        {
            Hücreler = MaçSatır.SelectNodes("td[not(@rowspan)]");
        }
    }
}