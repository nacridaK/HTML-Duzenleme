using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTML_Veri_Çekme
{
    class GrupOyuncu : IComparable
    {
        HtmlNode GrupSatır;
        public byte Sıra
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_Sıra']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_Sıra']/strong").InnerHtml = value.ToString() ?? "&nbsp;";
        }
        public string OyuncuAdı
        {
            get => GrupSatır.SelectSingleNode("td[@id='PT_Oyuncu']").InnerText;
            set => GrupSatır.SelectSingleNode("td[@id='PT_Oyuncu']").InnerHtml = value ?? "&nbsp;";
        }
        public string Arma
        {
            get
            {
                string[] Takım = GrupSatır.SelectSingleNode("td[@id='PT_Arma']").FirstChild.GetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/Belirsiz.png").Split('/');
                return Takım[Takım.Length - 1].Split('.')[0];
            }
            set => GrupSatır.SelectSingleNode("td[@id='PT_Arma']").FirstChild.SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/" + value + ".png");
        }
        public byte OynananMaç
        {
            get
            {
                GrupSatır.SelectSingleNode("td[@id='PT_O']").InnerHtml = (GalibiyetSayısı + BeraberlikSayısı + MağlubiyetSayısı).ToString();
                return byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_O']").InnerText);
            }
            set => GrupSatır.SelectSingleNode("td[@id='PT_O']").InnerHtml = value.ToString() ?? "0";
        }
        public byte GalibiyetSayısı
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_G']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_G']").InnerHtml = value.ToString() ?? "0";
        }
        public byte BeraberlikSayısı
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_B']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_B']").InnerHtml = value.ToString() ?? "0";
        }
        public byte MağlubiyetSayısı
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_M']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_M']").InnerHtml = value.ToString() ?? "0";
        }
        public byte AtılanGol
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_A']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_A']").InnerHtml = value.ToString() ?? "0";
        }
        public byte YenenGol
        {
            get => byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_Y']").InnerText);
            set => GrupSatır.SelectSingleNode("td[@id='PT_Y']").InnerHtml = value.ToString() ?? "0";
        }
        public int Averaj
        {
            get
            {
                GrupSatır.SelectSingleNode("td[@id='PT_AV']").InnerHtml = (AtılanGol - YenenGol).ToString();
                return int.Parse(GrupSatır.SelectSingleNode("td[@id='PT_AV']").InnerText);
            }
            set => GrupSatır.SelectSingleNode("td[@id='PT_AV']").InnerHtml = value.ToString() ?? "0";
        }
        public byte Puan
        {
            get
            {
                GrupSatır.SelectSingleNode("td[@id='PT_P']").InnerHtml = (3 * GalibiyetSayısı + BeraberlikSayısı).ToString();
                return byte.Parse(GrupSatır.SelectSingleNode("td[@id='PT_P']").InnerText);
            }
            set => GrupSatır.SelectSingleNode("td[@id='PT_P']").InnerHtml = value.ToString() ?? "0";
        }
        public static GrupOyuncu[] GrupOluştur(HtmlNode GrupTablosu)
        {
            HtmlNodeCollection GrupSatırlar = GrupTablosu.SelectNodes("tbody/tr[@id='PT_Satır']");
            GrupOyuncu[] Oyuncular = new GrupOyuncu[GrupSatırlar.Count];
            for (int i = 0; i < GrupSatırlar.Count; i++)
                Oyuncular[i] = new GrupOyuncu(GrupSatırlar[i]);
            return Oyuncular;
        }
        public static GrupOyuncu OyuncuBul(GrupOyuncu[] Grup,string OyuncuAdı)
        {
            for (int i = 0; i < Grup.Length; i++)
                if (Grup[i].OyuncuAdı == OyuncuAdı)
                    return Grup[i];
            return null;
        }
        public static void VerileriSıfırla(GrupOyuncu Oyuncu)
        {
            Oyuncu.OynananMaç = 0;
            Oyuncu.GalibiyetSayısı = 0;
            Oyuncu.BeraberlikSayısı = 0;
            Oyuncu.MağlubiyetSayısı = 0;
            Oyuncu.AtılanGol = 0;
            Oyuncu.YenenGol = 0;
            Oyuncu.Averaj = 0;
            Oyuncu.Puan = 0;
        }
        public static void VerileriSıfırla(GrupOyuncu[] Oyuncular)
        {
            for (int i = 0; i < Oyuncular.Length; i++)
                GrupOyuncu.VerileriSıfırla(Oyuncular[i]);
        }
        public void VerileriSıfırla()
        {
            VerileriSıfırla(this);
        }
        public void Galibiyet()
        {
            GalibiyetSayısı++;
        }
        public void Beraberlik()
        {
            BeraberlikSayısı++;
        }
        public void Mağlubiyet()
        {
            MağlubiyetSayısı++;
        }
        public void GolAttı(byte AtılanGol)
        {
            this.AtılanGol += AtılanGol;
        }
        public void GolYedi(byte YenenGol)
        {
            this.YenenGol += YenenGol;
        }
        public int CompareTo(object obj)
        {
            GrupOyuncu Oyuncu = obj as GrupOyuncu;
            if (this.Puan > Oyuncu.Puan)
                return -1;
            else if (this.Puan < Oyuncu.Puan)
                return 1;
            else if (this.Averaj > Oyuncu.Averaj)
                return -1;
            else if (this.Averaj < Oyuncu.Averaj)
                return 1;
            else if (this.AtılanGol > Oyuncu.AtılanGol)
                return -1;
            else if (this.AtılanGol < Oyuncu.AtılanGol)
                return 1;
            return 0;
        }
        private GrupOyuncu(HtmlNode GrupSatır)
        {
            this.GrupSatır = GrupSatır;
        }
    }
}