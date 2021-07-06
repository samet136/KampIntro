using System;

namespace ClasssIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac arac1 = new Arac();
            arac1.Marka = "BMW";
            arac1.Model = 2015;
            arac1.Renk = "Siyah";
            arac1.Fiyat = 150000;

            Arac arac2 = new Arac();
            arac2.Marka = "AUdi";
            arac2.Model = 2013;
            arac2.Renk = "Beyaz";
            arac2.Fiyat = 130000;

            Arac arac3 = new Arac();
            arac3.Marka = "Mercedes";
            arac3.Model = 2020;
            arac3.Renk = "Siyah";
            arac3.Fiyat = 250000;

            Arac[] araclar = new Arac[] { arac1,arac2,arac3};

            foreach (var a in araclar)
            {
                Console.WriteLine(a.Marka+" "+a.Model+" "+a.Renk+" "+a.Fiyat);
            }
            

        }
    }

    class Arac
    {
        public string Marka { get; set; }
        public int Model { get; set; }
        public string Renk { get; set; }
        public decimal Fiyat { get; set; }


    }

}
