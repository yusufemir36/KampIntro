using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string lurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Phayton", "C#"};
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            
            
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
