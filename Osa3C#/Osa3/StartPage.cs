using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.Json;

namespace Osa3C_.Osa3
{
    public class StartPage
    {
        public static void Main(string[] args)
        {

            // Osa3
            Console.WriteLine("""
                Tere! Vali tegevus: 
                1. Juhuslike arvude ruudud
                2. Viie arvu analüüs
                3. Nimed ja vanused
                4. Arvamise mäng
                5. Suurim neliarvuline arv
                6. Korrustustabel
                7. Õpilastega mängimine
                """);
            int valik = int.Parse(Console.ReadLine());
            if (valik == 1)
            {
                Console.WriteLine("Sisesta min arv: ");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta max arv: ");
                int max = int.Parse(Console.ReadLine());
                osa3.GenereeriRuudud(min, max);
            }
            else if (valik == 2)
            {
                double[] arvud = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Kirjuta {i + 1} arv.");
                    arvud[i] = double.Parse(Console.ReadLine());
                }
                var tulemus = osa3.AnalüüsiArve(arvud);

                Console.WriteLine($"Summa: {tulemus.Item1}");
                Console.WriteLine($"Keskmine: {tulemus.Item2}");
                Console.WriteLine($"Korrutis: {tulemus.Item3}");
            }
            else if (valik == 3)
            {
                osa3.Inimenefunc();
            }
            else if (valik == 4)
            {
                osa3.arvumang();
            }
            else if (valik == 5)
            {
                osa3.SuurimNeliarv();
            }
            else if (valik == 6)
            {
                osa3.GenereeriKorrutustabel(10, 10);
            }
            else if (valik == 7)
            {
                string[] nimed = { "Maks", "Vitalya", "Yarik", "Lev", "Oleg", "Dominic", "Nikita", "Kirill", "Dima", "Daria"};
                osa3.ÕpilastegaMängimine(nimed);
            }
        }
    }
}
