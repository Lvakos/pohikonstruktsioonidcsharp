using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Osa3C_.Osa3
{
    public class osa3
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            List<int> ruudud = new List<int>();

            for (int i = start; i <= end; i++)
            {
                int square = i * i;
                ruudud.Add(square);
                Console.WriteLine($"{square}");
            }
            return ruudud.ToArray();
        }

        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }

        private static Tuple<int, double, inimene, inimene> Statistika(List<inimene> inimesed)
        {
            int summa = inimesed.Sum(i => i.Vanus);
            double keskmine = inimesed.Average(i => i.Vanus);
            inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
            inimene noorem = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine, vanim, noorem);
        }
        public static void Inimenefunc()
        {

            List<inimene> Inimesed = new List<inimene>();
            /*inimene inimene1 = new inimene("Maks", 16);
            Inimesed.Add(inimene1);*/
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Mis on {i + 1}, Nimi?: ");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Mis on {i + 1} inimese vanus?: ");
                int vanus = int.Parse(Console.ReadLine());
                inimene inimene2 = new inimene(nimi, vanus);
                Inimesed.Add(inimene2);
            }
            var analüüs = osa3.Statistika(Inimesed);
            Console.WriteLine($"Vanuste arv: {analüüs.Item1}. Vanuste keskmine: {analüüs.Item2}. Noorim inimene: {analüüs.Item3.Nimi}. Vanem inimene: {analüüs.Item4.Nimi}");
        }

        public static void ostsElevantAra()
        {
            string vastus;
            do
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();

            } while (vastus != "jah");

            while (true)
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();
                if (vastus == "jah")
                {
                    Console.WriteLine("Oled ostnud elevandi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kõik nii rakivad, aga Osts elevant ära");
                }
            }
        }

        public static void arvumang()
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);
            int tries = 5;

            for (int i = 1; i <= tries; i++)
            {
                Console.Write("Arva arv: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("Õige!");
                    return;
                }
                else if (guess > secret)
                    Console.WriteLine("Liiga suur");
                else
                    Console.WriteLine("Liiga väike");
            }

            Console.WriteLine($"Kaotasid! Arv oli {secret}");
        }
        public static int SuurimNeliarv()
        {
            List<int> arvudList = new List<int>();


            while (arvudList.Count < 4)
            {
                Console.Write($"Number {arvudList.Count + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < 0 || number > 9)
                    {
                        Console.WriteLine("Number peab olema 0–9!");
                    }
                    else
                    {
                        arvudList.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Palun sisesta korrektne arv!");
                }
            }

            int[] arvud = arvudList.ToArray();

            foreach (var a in arvud)
                if (a < 0 || a > 9)
                    throw new Exception("Peab olema 0-9");

            Array.Sort(arvud);
            Array.Reverse(arvud);

            return int.Parse(string.Join("", arvud));
        }

        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            return tabel;
        }

        public static void ÕpilastegaMängimine(string[] nimed)
        {
            Console.WriteLine("Sisesta uus nimi: ");
            string nimi1 = Console.ReadLine();
            nimed[2] = nimi1;
            nimed[5] = "Mati";

            int i = 0;
            while (i< nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }

            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"Indeks: {j}, Nimi: {nimed[j]}");
            }

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }

            i = 0;
            do
            {
                if (nimed[i] == "Mati")
                {
                    Console.WriteLine("Leidsin Mati!");
                    break;
                }
                Console.WriteLine($"Tere, {nimed[i]}!");
            }
            while (i < nimed.Length);
        }

        public static void arvudRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"arv: {arvud[i]} ruut: {arvud[i] * arvud[i]}");
            }
            foreach (int arv in arvud)
            {
                Console.WriteLine($"arv: {arv} ruut: {arv * 2}");
            }
            while (true)
            {
                int i = 0;
                int count = 0;

                while (i < arvud.Length)
                {
                    if (arvud[i] % 3 == 0) // 0 kui on õige
                    {
                        count++;
                    }

                    i++;
                }

                Console.WriteLine("Jagab 3: " + count);

            }
        }

        public static void Positiivsed_ja_negatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;
            foreach (int arv in arvud)
            {
                if (arv > 0)
                {
                    positiivsed++;
                }
                else if (arv < 0)
                {
                    negatiivsed++;
                }
                else
                {
                    nullid++;
                }

            }
            Console.WriteLine($"Positiivsed: {positiivsed}");
            Console.WriteLine($"Negatiivsed: {negatiivsed}");
            Console.WriteLine($"Nullid: {nullid}");
        }

        public static void rohkemkuiKeskmine()
        {
            Random rnd = new Random();
            int arvu = rnd.Next(1, 101);
            int[] arvud = new int[15];
            int summa = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
            }
            double keskmine = summa / arvud.Length;
            Console.WriteLine($"Keskmine: {keskmine}");
            Console.WriteLine("Arvud, mis on suuremad kui keskmine:");
            foreach (int arv in arvud)
            {
                if (arv > keskmine)
                {
                    Console.WriteLine(arv);
                }
            }
        }

        public static void suurimJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0]; // Eeldame, et esimene element on suurim
            int index = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i]; // Uuendame suurimat väärtust
                    index = i;
                }
            }

            Console.WriteLine("surim: " + max);
            Console.WriteLine("indeks: " + index);
        }

        public static void binaariOsting()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            numbrid = numbrid.OrderBy(n => n).ToArray();
            int vasak = 0;
            int parem = numbrid.Length - 1;
            while (vasak <= parem)
            {
                int keskmine = vasak + (parem - vasak) / 2;

                if (numbrid[keskmine] == 78)
                {
                    Console.WriteLine("Leidsin 78 indeksil: " + keskmine);
                    return;
                }
                else if (numbrid[keskmine] < 78)
                {
                    vasak = keskmine + 1;
                }
                else
                {
                    parem = keskmine - 1;
                }
            }
        }

        public static void PaariPaaritud()
        {
            Random rnd = new Random();
            List<int> Arvud = new List<int>();
            int summa = 0;
            int keskmine = 0;
            for (int i = 0; i < 20; i++)
            {
                Arvud.Add(rnd.Next(1, 21));
            }
            for (int i = 0; i < Arvud.Count; i++)
            {


                if (Arvud[i] % 2 == 0)
                {
                    summa += Arvud[i];
                }
                else
                {
                    keskmine += Arvud[i];

                }
            }
            Console.WriteLine($"Summa: {summa}, keskmine: {keskmine}");

        }
    }
}