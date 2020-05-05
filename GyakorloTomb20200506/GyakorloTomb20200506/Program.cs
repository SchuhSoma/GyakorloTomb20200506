using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorloTomb20200506
{
    class Program
    { 
        static int[] Februar = new int[28];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*Feladat1(); 
            Console.WriteLine("\n------------------------------------------\n");
            Feladat2();
            Console.WriteLine("\n------------------------------------------\n");*/
            Feladat3();
            Console.ReadKey();
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat:" +
                "\n\tKészíts programot a februári napi hőmérsékletek tárolására, \n\ta tömb elemei február hónap napjainak felelnek meg!");
            int Homerseklet = 0;
            Februar = new int[28];
            for (int i = 0; i < Februar.Length; i++)
            {
                Homerseklet = rnd.Next(-5,16);
                Februar[i] = Homerseklet;
            }
            Console.WriteLine("\n------------------------------------------\n");
            TombKiiratas();
            Console.WriteLine("\n------------------------------------------\n");
            TombAtlaga();
            Console.WriteLine("\n------------------------------------------\n");
            MinMax();
            Console.WriteLine("\n------------------------------------------\n");
            OtCelzius();
        }

        private static void OtCelzius()
        {
            Console.WriteLine("\tTömb elemeinek között hányszor volt 5°C\n");
            int db = 0;
            foreach (var f in Februar)
            {
                if(f==5)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi alkalommal volt 5°C-os a hőmérséklet: {0}", db);
            Console.ReadKey();
            Console.Clear();
        }

        private static void MinMax()
        {
            Console.WriteLine("\tTömb elemeinek minimuma, maximuma\n");
            int Max = int.MinValue;
            int MaxHely = 0;
            int Min = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i < Februar.Length; i++)
            {
                if(Max<Februar[i])
                {
                    Max = Februar[i];
                    MaxHely = i +1;
                }
                if(Min>Februar[i])
                {
                    Min = Februar[i];
                    MinHely = i + 1;
                }
            }
            Console.WriteLine("\tA legnagyobb hőmérséklet feburárban: {0} °C-> Február {1}-én volt.", Max, MaxHely);
            Console.WriteLine("\tA legalacsonyabb hőmérséklet feburárban: {0} °C-> Február {1}-én volt.", Min, MinHely);
            Console.ReadKey();
            Console.Clear();
        }

        private static void TombAtlaga()
        {
            Console.WriteLine("\tTömb elemeinek átlaga\n");
            double Osszeg = 0;
            double Atlag = 0; ;
            for (int i = 0; i < Februar.Length; i++)
            {
                Osszeg += Februar[i];
                Atlag = Osszeg / Februar.Length;
            }
            Console.WriteLine("\tA febrári hőmérséklet átlaga: {0:0.00} °C", Atlag);
            Console.ReadKey();
            Console.Clear();
        }

        private static void TombKiiratas()
        {
            Console.WriteLine("\tTömb elemeinek kiratása\n");
            for (int i = 0; i < Februar.Length; i++)
            {
                Console.WriteLine("\tFebruár {0:00}. -> hőmérséklet: {1,-3} °C", i + 1, Februar[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat:" +
                "\n\tKészíts programot, amely egymás mellé szóközzel elválasztva kiírja a 100 és 300 közötti, " +
                "\n\t3-mal és 7-tel is maradék nélkül osztható egész számokat!");
            int Szam = 0;
            for (int i = 100; i < 301; i++)
            { 
                Szam = i;
                if(Szam%3==0 && Szam%7==0)
                {
                    Console.Write("\t{0} , ",Szam );
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: " +
                "\n\tKészíts programot, a napok sorszámmal történő beazonosítására! \n" +
                "\tKérj be a billentyűzetről a felhasználótól egy 1 és 7 közzé eső, " +
                "\n\tegész számot! " +
                "\tA program írja ki, hogy az adott szám, melyik napot jelöli!\n" +
                "\tAz 1 - es érték jelenti a hétfőt, a 2 - es a keddet a 7 - es a vasárnapot!\n" +
                "\tAmennyiben az adott szám nem a megadott intervallumba esik, abban az esetben írja " +
                "\n\tki a felhasználónak, hogy „Rossz számot adott meg!");

            int Bekert = 0;
            do
            {
                Console.Write("\n\tKérem adjon meg egy egész számot 1 és 7 között: ");
                Bekert = int.Parse(Console.ReadLine());
                if (Bekert < 1 || Bekert > 7) Console.WriteLine("\tSajnos rossz érték");

            } while (Bekert < 1 || Bekert > 7);
            
            if (Bekert == 1) Console.WriteLine("\tEhhez a számhoz a hétfő tartozik");
            if (Bekert == 2) Console.WriteLine("\tEhhez a számhoz a kedd tartozik");
            if (Bekert == 3) Console.WriteLine("\tEhhez a számhoz a szerda tartozik");
            if (Bekert == 4) Console.WriteLine("\tEhhez a számhoz a csütörtök tartozik");
            if (Bekert == 5) Console.WriteLine("\tEhhez a számhoz a péntek tartozik");
            if (Bekert == 6) Console.WriteLine("\tEhhez a számhoz a szombat tartozik");
            if (Bekert == 7) Console.WriteLine("\tEhhez a számhoz a vasárnap tartozik");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
