using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Osa3C_.Osa5
{
    internal class ulesanded
    {
        public class Toode
        {
            public string Nimi { get; set; }

            public double Kalorid100g { get; set; }
        }
        public class Inimene
        {
            public string Nimi { get; set; }

            public int Vanus { get; set; }

            public string Sugu { get; set; }

            public int Pikkus { get; set; }

            public int Kaal { get; set; }

            public string Aktiivsustase { get; set; }
        }

        public static void KalooriteKalk()
        {
            try
            {

                List<Toode> toidud = new List<Toode>
                {
                    new Toode { Nimi = "Õun", Kalorid100g = 52 },
                    new Toode { Nimi = "Leib", Kalorid100g = 265 },
                    new Toode { Nimi = "Kanafilee", Kalorid100g = 165 },
                    new Toode { Nimi = "Kartul", Kalorid100g = 77 },
                    new Toode { Nimi = "Munad", Kalorid100g = 155 }
                };

                Inimene kasutaja = new Inimene();

                Console.WriteLine("nimi:");
                kasutaja.Nimi = Console.ReadLine();

                Console.WriteLine("vanus (aastates):");
                kasutaja.Vanus = int.Parse(Console.ReadLine());

                Console.WriteLine("sugu (M/N):");
                kasutaja.Sugu = Console.ReadLine().ToUpper();

                Console.WriteLine("pikkus (cm):");
                kasutaja.Pikkus = int.Parse(Console.ReadLine());

                Console.WriteLine("kaal (kg):");
                kasutaja.Kaal = int.Parse(Console.ReadLine());

                Console.WriteLine("aktiivsustase (madal/keskmine/kõrge):");
                kasutaja.Aktiivsustase = Console.ReadLine().ToLower();


                double BMR = 0;

                if (kasutaja.Sugu == "M")
                {
                    BMR = 66.47 + (13.75 * kasutaja.Kaal) + (5.0 * kasutaja.Pikkus) - (6.75 * kasutaja.Vanus);
                }
                else if (kasutaja.Sugu == "N")
                {
                    BMR = 655.1 + (9.56 * kasutaja.Kaal) + (1.85 * kasutaja.Pikkus) - (4.68 * kasutaja.Vanus);
                }

                double aktiivsusKordaja = 1.2;
                if (kasutaja.Aktiivsustase == "keskmine")
                    aktiivsusKordaja = 1.55;
                else if (kasutaja.Aktiivsustase == "kõrge")
                    aktiivsusKordaja = 1.9;

                double päevaneKalor = BMR * aktiivsusKordaja;

                Console.WriteLine($"{kasutaja.Nimi}, sinu päevane kalorivajadus on: {päevaneKalor:F0} kcal");
                Console.WriteLine("Toidunimekiri ja soovituslik kogus päevas (g):");

                foreach (var t in toidud)
                {
                    double gramm = (päevaneKalor / t.Kalorid100g) * 100;
                    Console.WriteLine($"{t.Nimi} - umbes {gramm:F0} g");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Midagi läks valesti: " + ex);
            }
        }

        public static void maakondJapealinnad()
        {
            Random rnd = new Random();
            Dictionary<string, string> maakonnad = new Dictionary<string, string>
            {
                { "Harjumaa", "Tallinn" },
                { "Hiiumaa", "Kärdla" },
                { "Ida-Virumaa", "Jõhvi" },
                { "Jõgevamaa", "Jõgeva" },
                { "Järvamaa", "Paide" },
                { "Läänemaa", "Haapsalu" },
                { "Lääne-Virumaa", "Rakvere" },
                { "Põlvamaa", "Põlva" },
                { "Pärnumaa", "Pärnu" },
                { "Raplamaa", "Rapla" },
                { "Saaremaa", "Kuressaare" },
                { "Tartumaa", "Tartu" },
                { "Valgamaa", "Valga" },
                { "Viljandimaa", "Viljandi" },
                { "Võrumaa", "Võru" }
            };

            try
            {
                Console.WriteLine("Sisesta pealinn: ");
                string pealinn = Console.ReadLine();

                foreach (var paar in maakonnad)
                {
                    if (paar.Value == pealinn)
                    {
                        Console.WriteLine($"{pealinn} maakond on {paar.Key}");
                    }
                }
            }

            catch(Exception x)
            {
                Console.WriteLine($"Midagi läks valesti {x}");
            }

            try
            {
                Console.WriteLine("Sisesta maakond: ");
                string maakond = Console.ReadLine();

                foreach (var paar in maakonnad)
                {
                    if (paar.Key == maakond)
                    {
                        Console.WriteLine($"{maakond} pealinn on {paar.Value}");
                    }
                }
            }

            catch (Exception x)
            {
                Console.WriteLine($"Midagi läks valesti {x}");
            }

            List<string> rndmaakonnad = maakonnad.Keys.OrderBy(x => rnd.Next()).ToList();
            string sisend = "";
            int kogemus = 0;

            foreach (string maakondd in rndmaakonnad)
            {
                Console.WriteLine($"Mis on {maakondd} keskus?");
                sisend = Console.ReadLine().Trim();
                sisend = char.ToUpper(sisend[0]) + sisend.Substring(1).ToLower();

                if (sisend == maakonnad[maakondd])
                {
                    Console.WriteLine("Õige!");
                    kogemus++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus on {maakonnad[maakondd]}");
                }
            }

            Console.WriteLine($"Tulemus: {kogemus}/{maakonnad.Count()}");

        }
    }
}
