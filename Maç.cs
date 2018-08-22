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
        HtmlNode MaçSatır;
        public string Kod
        {
            get => MaçSatır.SelectSingleNode("td[@id='MT_K']").InnerText;
            set => MaçSatır.SelectSingleNode("td[@id='MT_K']").InnerHtml = value ?? "&nbsp;";
        }
        public bool OynandıMı
        {
            get => EvSahibiGol != "&nbsp;" && KonukGol != "&nbsp;";
        }
        public int Hükmen
        {
            get => int.Parse(MaçSatır.SelectSingleNode("td[@id='MT_K']").GetAttributeValue("hükmen", null));
            set
            {
                value = Math.Sign(value);
                if (value == -1)
                {
                    EvSahibiGol = "2";
                    KonukGol = "0";
                }
                else if (value == 1)
                {
                    EvSahibiGol = "0";
                    KonukGol = "2";
                }
                MaçSatır.SelectSingleNode("td[@id='MT_K']").SetAttributeValue("hükmen", value.ToString());
            }
        }
        public int Sonuç
        {
            get
            {
                int EvSahibi = int.Parse(EvSahibiGol);
                int Konuk = int.Parse(KonukGol);
                if (EvSahibi > Konuk)
                    return -1;
                else if (Konuk > EvSahibi)
                    return 1;
                else
                    return 0;
            }
        }
        public string EvSahibiArma
        {
            set => MaçSatır.SelectSingleNode("td[@id='MT_E_A']").FirstChild.SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/" + value + ".png");
        }
        public string EvSahibi
        {
            get => MaçSatır.SelectSingleNode("td[@id='MT_E_O']").InnerText;
            set => MaçSatır.SelectSingleNode("td[@id='MT_E_O']").InnerHtml = value ?? "&nbsp;";
        }
        public string EvSahibiGol
        {
            get => MaçSatır.SelectSingleNode("td[@id='MT_E_G']").InnerText;
            set
            {
                if (Hükmen == 0)
                    MaçSatır.SelectSingleNode("td[@id='MT_E_G']").InnerHtml = value ?? "&nbsp;";
            }
        }
        public string KonukArma
        {
            set => MaçSatır.SelectSingleNode("td[@id='MT_K_A']").FirstChild.SetAttributeValue("src", "http://www.turkcespiker.com/files/alike/arena/ex16_Test/FAPONTE/armalar/" + value + ".png");
        }
        public string KonukGol
        {
            get => MaçSatır.SelectSingleNode("td[@id='MT_K_G']").InnerText;
            set
            {
                if (Hükmen == 0)
                    MaçSatır.SelectSingleNode("td[@id='MT_K_G']").InnerHtml = value ?? "&nbsp;";
            }
        }
        public string Konuk
        {
            get => MaçSatır.SelectSingleNode("td[@id='MT_K_O']").InnerText;
            set => MaçSatır.SelectSingleNode("td[@id='MT_K_O']").InnerHtml = value ?? "&nbsp;";
        }
        public static Maç[] MaçlarOluştur(HtmlNode MaçTablosu)
        {
            HtmlNodeCollection MaçSatırlar = MaçTablosu.SelectNodes("tbody/tr[@id='MT_Satır']");
            Maç[] Maçlar = new Maç[MaçSatırlar.Count];
            for (int i = 0; i < MaçSatırlar.Count; i++)
                Maçlar[i] = new Maç(MaçSatırlar[i]);
            return Maçlar;
        }
        private Maç(HtmlNode MaçSatır)
        {
            this.MaçSatır = MaçSatır;
        }
    }
}