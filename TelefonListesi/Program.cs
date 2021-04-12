using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonListesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon();

            telefon1.TelefonId = 1;
            telefon1.Marka = "Samsung Galaksi S10";
            telefon1.Fiyat = 5499;
            telefon1.Renk = Color.White;
            telefon1.EkranBoyutu = 6.4;
            telefon1.Agirlik = 175;
            telefon1.KameraCözünürlügü = 12;
            telefon1.DahiliDepolama = 128;
            telefon1.RAM = 6;
            telefon1.BataryaKapasitesi = 3400;
            telefon1.IsletimSistemi = IsletimSistemi.Android;
            telefon1.SuyaDayaniklilik = true;
            telefon1.ParmakIziOkuyucu = true;
            telefon1.CPUFrekansi = 2.73;

            Telefon telefon2 = new Telefon();

            telefon2.TelefonId = 2;
            telefon2.Marka = "Iphone 12 Pro";
            telefon2.Fiyat = 13795;
            telefon2.Renk = Color.Gold;
            telefon2.EkranBoyutu = 6.1;
            telefon2.Agirlik = 189;
            telefon2.KameraCözünürlügü = 12;
            telefon2.DahiliDepolama = 128;
            telefon2.RAM = 6;
            telefon2.BataryaKapasitesi = 2815;
            telefon2.IsletimSistemi = IsletimSistemi.İOS;
            telefon2.SuyaDayaniklilik = true;
            telefon2.ParmakIziOkuyucu = true;
            telefon2.CPUFrekansi = 3.0;

            Telefon telefon3 = new Telefon();

            telefon3.TelefonId = 3;
            telefon3.Marka = "Huawei P20 Lite";
            telefon3.Fiyat = 1949;
            telefon3.EkranBoyutu = 5.84;
            telefon3.Agirlik = 145;
            telefon3.KameraCözünürlügü = 16;
            telefon3.DahiliDepolama = 64;
            telefon3.BataryaKapasitesi = 3000;
            telefon3.IsletimSistemi = IsletimSistemi.Android;
            telefon3.CPUFrekansi = 2.36;

            Console.WriteLine("------------------------------------------BUSRA TELEFON DÜNYASI---------------------------------------------------");
            Console.WriteLine("                                                                                 ");
            Telefon[] telefonlar = new Telefon[] { telefon1, telefon2, telefon3 };

            foreach (var telefon in telefonlar)
            {
                Console.WriteLine
                    ("Telefon Markası: " + telefon.Marka + " / Telefon Fiyatı: " + telefon.Fiyat + " TL" + "\n" +
                    "Telefon Özellikleri " +
                    "\n" + "Renk :" + telefon.Renk + " / Ekran Boyutu : " + telefon.EkranBoyutu + " inç " + " / Ağırlık : " + telefon.Agirlik + " Gr." +
                    "\n" + "Kamera Çözünürlüğü : " + telefon.KameraCözünürlügü + " MP " + " / Dahili Depolama : " + telefon.DahiliDepolama + " GB " + " / RAM : " + telefon.RAM + " GB " + " / Batarya Kapasitesi : " + telefon.BataryaKapasitesi + " mAh " +
                    "\n" + "İşletim Sistemi : " + telefon.IsletimSistemi + " / Suya Dayanıklılık : " + telefon.SuyaDayaniklilik + " / Parmak İzi Okuma : " + telefon.ParmakIziOkuyucu + " / CPU Frekansı : " + telefon.CPUFrekansi + " GHz"
                    );
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            }

            Console.ReadLine();

            //Console.WriteLine(telefon1.Agirlik);
        }
    }
}
