using System;
using System.Collections.Generic;
using System.Text;
namespace Osa3C_
{
    public class Code
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
            var analüüs = Code.Statistika(Inimesed);
            Console.WriteLine($"Vanuste arv: {analüüs.Item1}, Vanuste keskmine: {analüüs.Item2}, Noorim inimene: {analüüs.Item3.Nimi}, Vanem inimene: {analüüs.Item4.Nimi}");
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
    }
}