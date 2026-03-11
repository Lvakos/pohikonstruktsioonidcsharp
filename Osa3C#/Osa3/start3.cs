using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.Json;

namespace Osa3C_.Osa3
{
    public class start3
    {
        public static void Main(string[] args)
        {

            // Osa3
            Console.WriteLine("""
                Tere! Vali tegevus: 
                1. Juhuslike arvude ruudud
                2. Viie arvu analüüs
                3. Nimed ja vanused
                4. Osta elevant ära!
                5. Arvamise mäng
                6. Suurim neliarvuline arv
                7. Korrustustabel
                8. Õpilastega mängimine
                9. Arvude ruudud
                10. Positiivsed ja negatiivsed
                11. Keskmisest suuremad
                12. Kõige suurema arvu otsing
                13. Paari- ja paaritud loendused
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
                osa3.ostsElevantAra();
            }
            else if (valik == 5)
            {
                osa3.arvumang();
            }
            else if (valik == 6)
            {
                osa3.SuurimNeliarv();
            }
            else if (valik == 7)
            {
                osa3.GenereeriKorrutustabel(10, 10);
            }
            else if (valik == 8)
            {
                string[] nimed = { "Maks", "Vitalya", "Yarik", "Lev", "Oleg", "Dominic", "Nikita", "Kirill", "Dima", "Daria"};
                osa3.ÕpilastegaMängimine(nimed);
            }
            else if (valik == 9)
            {
               
                osa3.arvudRuudud();
            }
            else if (valik == 10)
            {

                osa3.Positiivsed_ja_negatiivsed();
            }
            else if (valik == 11)
            {

                osa3.rohkemkuiKeskmine();
            }
            else if (valik == 12)
            {

                osa3.suurimJaIndeks();
            }
            else if (valik == 13)
            {

                osa3.PaariPaaritud();
            }
        }
    }
}
