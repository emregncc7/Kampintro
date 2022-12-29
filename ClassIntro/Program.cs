using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 35;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Phyton";
            kurs2.Egitmen = "Emre Genç";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Savaş";
            kurs3.IzlenmeOrani = 65;

            Kurs[] kurs = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurss in kurs)
            {
                Console.WriteLine(kurss.KursAdi + " : " + kurss.Egitmen );
            }
        }
    }

    class Kurs
    {
        public string KursAdi{ get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
