﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventTrafikKontrol
{
    public enum AracTipi
    {
        Otomobil=1,
        Kamyon,
        Ticari
    }
    public class Sofor
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Plaka { get; set; }
        public AracTipi AracTipi { get; set; }
        public int Hiz { get; set; }


        public delegate void HizAsimiHandler(object sender, HizAsimiEventArgs e);
        public event HizAsimiHandler HizAsimi;

        public Sofor(string ad, string soyad, string plaka, AracTipi aracTipi)
        {
            Ad = ad;
            Soyad = soyad;
            Plaka = plaka;
            AracTipi = aracTipi;
        }
        public void GazaBas(int hiz)
        {
            Hiz = hiz;
            int ceza = 0;
            bool hizLimitiniGecti = false;

            if (AracTipi == AracTipi.Otomobil && Hiz > 120)
            {
                ceza = 800;
                hizLimitiniGecti = true;
            }
            else if (AracTipi == AracTipi.Kamyon && Hiz > 80)
            {
                ceza = 1500;
                hizLimitiniGecti = true;
            }
            else if (AracTipi == AracTipi.Ticari && Hiz > 90)
            {
                ceza = 1000;
                hizLimitiniGecti = true;
            }

            if (hizLimitiniGecti && HizAsimi != null)
            {
                HizAsimi(this, new HizAsimiEventArgs(Plaka, Hiz, ceza));
            }
        }
    }
}

