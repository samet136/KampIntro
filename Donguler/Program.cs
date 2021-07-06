using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kursu",
                "Java Başlangıç İçin Temel Kurs",
                "Java",
                "Phyton Kursu"
            };

            for (int i =3 ; i >= 0; i--)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Döngüsü Bitti..");

            foreach (var k in kurslar)
            {
                Console.WriteLine(k);
            }
        }
    }
}
