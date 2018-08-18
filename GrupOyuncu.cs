using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTML_Veri_Çekme
{
    class GrupOyuncu
    {
        HtmlNode GrupSatır;
        public string Sıra
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_Sıra']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_Sıra']").InnerHtml = value ?? "&nbsp;";
        }
        public string OyuncuAdı
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_Oyuncu']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_Oyuncu']").InnerHtml = value ?? "&nbsp;";
        }
        public string Arma
        {
            set => GrupSatır.SelectSingleNode("td[@id='PT_Arma']").FirstChild.SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/" + value + ".png" ?? "Belirsiz.png");
        }
        public string OynananMaç
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_O']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_O']").InnerHtml = value ?? " ";
        }
        public string GalibiyetSayısı
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_G']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_G']").InnerHtml = value ?? " ";
        }
        public string BeraberlikSayısı
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_B']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_B']").InnerHtml = value ?? " ";
        }
        public string MağlubiyetSayısı
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_M']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_M']").InnerHtml = value ?? " ";
        }
        public string AtılanGol
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_A']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_A']").InnerHtml = value ?? " ";
        }
        public string YenenGol
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_Y']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_Y']").InnerHtml = value ?? " ";
        }
        public string Averaj
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_AV']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_AV']").InnerHtml = value ?? " ";
        }
        public string Puan
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_P']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_P']").InnerHtml = value ?? " ";
        }
        public static GrupOyuncu[] GrupOluştur(HtmlNode GrupTablosu)
        {
            HtmlNodeCollection GrupSatırlar = GrupTablosu.SelectNodes("tbody/tr[@id='PT_Satır']");
            GrupOyuncu[] Oyuncular = new GrupOyuncu[GrupSatırlar.Count];
            for (int i = 0; i < GrupSatırlar.Count; i++)
                Oyuncular[i] = new GrupOyuncu(GrupSatırlar[i]);
            return Oyuncular;
        }
        private GrupOyuncu(HtmlNode GrupSatır)
        {
            this.GrupSatır = GrupSatır;
        }
    }
}