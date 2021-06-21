using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ibo";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursEgitmen = "ibo";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursEgitmen = "kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursEgitmen = "berkay";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.KursEgitmen = "murat";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
