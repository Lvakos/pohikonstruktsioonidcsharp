using System;
using System.Collections.Generic;
using System.Text;
namespace Osa3C_
{
    internal class osa3
    {
        
        public int[] Genereeri()
        {
            Random rnd = new Random();
            int N = rnd.Next(1, 9);
            int M = rnd.Next(1, 9);

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
    }
   
}