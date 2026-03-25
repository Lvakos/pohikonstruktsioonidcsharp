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
        public static void opilased(List<opilane> opilased)
        {

            opilased = opilased.OrderByDescending(o => o.Hinded.Average()).ToList();
            foreach (opilane opilane in opilased)
            {
                double keskmine = opilane.Hinded.Average();
                Console.WriteLine($"{opilane.Nimi} keskminehind: {keskmine}");

            }
            Console.WriteLine($"parim keskmine hind:  {opilased[0].Nimi} {opilased[0].Hinded.Average()} ");

        }

        public static void Tekstist_arvud()
        {
            int suuremKui = 0;
            double[] masiiv = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"sisesta {i}. arv: ");
                masiiv[i] = double.Parse(Console.ReadLine());


            }

            Array.Sort(masiiv);
            foreach (double arv in masiiv)
            {
                Console.WriteLine(arv);
                if (arv > masiiv.Average())
                {
                    suuremKui++;
                }
            }


            double min = masiiv.Min();
            double max = masiiv.Max();
            double keskmine = masiiv.Average();

            Console.WriteLine($"Maksimaalne arv masiivist: {max}");
            Console.WriteLine($"Minimaalne arv masiivist: {min}");
            Console.WriteLine($"Keskmine arv masiivist: {keskmine}");
            Console.WriteLine($"Arvudest suurem kui keskmine: {suuremKui}");





        }

        public static void Lemmikloomade_register()
        {

            List<Lemmikloom> lemmikloomad = new List<Lemmikloom>();

            for (int i = 0; i < 5; i++)
            {
                Lemmikloom loom = new Lemmikloom();

                Console.Write($"Sisesta {i + 1}. looma nimi: ");
                loom.Nimi = Console.ReadLine();

                Console.Write($"Sisesta {i + 1}. looma liik (kass/koer jne): ");
                loom.Liik = Console.ReadLine();

                Console.Write($"Sisesta {i + 1}. looma vanus: ");
                loom.Vanus = int.Parse(Console.ReadLine());

                lemmikloomad.Add(loom);
                Console.WriteLine("----------------------------");
            }
            foreach (Lemmikloom l in lemmikloomad)
            {
                if (l.Liik.ToLower() == "kass")
                {
                    Console.WriteLine("Kass: " + l.Nimi + ", Liik: " + l.Liik + ", Vanus: " + l.Vanus);
                }
            }
            double keskmineVanus = lemmikloomad.Average(l => l.Vanus);
            lemmikloomad.Sort((x, y) => y.Vanus.CompareTo(x.Vanus));
            string vaneimLoom = lemmikloomad[0].Nimi;



            Console.WriteLine($"Vanim loom: {vaneimLoom}");
            Console.WriteLine($"Keskmine vanus: {keskmineVanus}");
            Console.WriteLine("kas sa tahad otsida mingi loom (jah/ei)?:  ");
            string otsing = Console.ReadLine().ToLower();
            if (otsing == "jah")
            {
                Console.WriteLine("Sisesta otsitav loom: ");
                string ostsitudLoom = Console.ReadLine();
                for (int lo = 0; lo < lemmikloomad.Count; lo++)
                {
                    if (ostsitudLoom == lemmikloomad[lo].Nimi)
                    {
                        Console.WriteLine($"Loom leitud: {lemmikloomad[lo].Nimi}, Liik: {lemmikloomad[lo].Liik}, Vanus: {lemmikloomad[lo].Vanus}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Looma ei leitud!");
                        break;
                    }
                }
            }

        }



        public static void ValuteCalculator()
        {
            List<Valute> valutes = new List<Valute>()
        {
            new Valute("UAH", 50.90),
            new Valute("CZK", 24.46),
            new Valute("USD", 1.16)
        };
            while (true)
            {
                Console.Write("Sisesta summa: ");
                double summa = double.Parse(Console.ReadLine());

                Console.Write("Sisesta valuut (UAH, CZK, USD): ");
                string valuut = Console.ReadLine().ToUpper();

                Console.WriteLine("otsi või müüa?");
                string valik = Console.ReadLine().ToLower();


                Valute selected = valutes.Find(v => v.Nimi == valuut);

                if (selected != null)
                {
                    if (valik == "müüa")
                    {
                        double eur = summa / selected.Kurs;

                        double value = eur * selected.Kurs;

                        Console.WriteLine($"1 EUR = {selected.Kurs} {selected.Nimi}");
                        Console.WriteLine($"{summa} {selected.Nimi} = {eur} EUR");
                        break;

                    }
                    else if (valik == "otsi")
                    {
                        double eur = summa * selected.Kurs;
                        double value = eur / selected.Kurs;
                        Console.WriteLine($"1 EUR = {selected.Kurs} {selected.Nimi}");
                        Console.WriteLine($"{summa} EUR = {eur} {selected.Nimi}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vigane valik!");
                    }




                }
                else
                {
                    Console.WriteLine("Meie bank ei tea selle valuut :( ");
                }

            }
        }
    }
}
