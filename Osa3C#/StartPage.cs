using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.Json;

namespace Osa3C_
{
    public class StartPage
    {
        
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            Console.ReadLine();*/

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
                Code.GenereeriRuudud(min, max);
            }
            else if (valik == 2)
            {

            }
            else if (valik == 3)
            {
                Code.Inimenefunc();
            }
            else if (valik == 4)
            {
                Code.arvumang();
            }
            else if (valik == 5)
            {
                Code.SuurimNeliarv();
            }
            else if (valik == 6)
            {
                Code.GenereeriKorrutustabel(10, 10);
            }
            else if (valik == 7)
            {
                string[] nimed = { "Maks", "Vitalya", "Yarik", "Lev", "Oleg", "Dominic", "Nikita", "Kirill", "Dima", "Daria"};
                Code.ÕpilastegaMängimine(nimed);
            }
        }
    }
}
