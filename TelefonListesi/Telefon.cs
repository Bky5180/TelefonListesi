using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonListesi
{
    class Telefon
    {
        public Telefon()
        {
            Fiyat = 7000;
            Renk = Color.Black;
            Agirlik = 150;
            RAM = 8;
            CPUFrekansi = 2.73;
            SuyaDayaniklilik = false;
            ParmakIziOkuyucu = false;
        }

        public int TelefonId { get; set; }
        public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public Color Renk { get; set; }
        public double EkranBoyutu { get; set; }
        public int Agirlik { get; set; }
        public int KameraCözünürlügü { get; set; }
        public int DahiliDepolama { get; set; }
        public int RAM { get; set; }
        public int BataryaKapasitesi { get; set; }
        public IsletimSistemi IsletimSistemi { get; set; }
        public bool SuyaDayaniklilik { get; set; }
        public bool ParmakIziOkuyucu { get; set; }
        public double CPUFrekansi { get; set; }



    }
    public enum IsletimSistemi
    {
        Android,
        İOS,
        BlackBerry

    }

    //public class Agirlik
    //{
    //    public int En { get; set; }
    //    public int Boy { get; set; }
    //}


}

