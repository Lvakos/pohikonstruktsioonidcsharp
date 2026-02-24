using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Osa3C_.Osa2
{
    public class osa2
    {
        public static string Juku(string nimi)
        {
            string otsus = "";
            string pilet = "";
            string vastus = "";
            int vanus = 0;
            if (nimi.ToLower() == "juku")
            {
                Console.Write("Kui vana Juku on?: ");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus < 100)
                    {
                        if (vanus < 6)
                        {
                            pilet = "kinopilet on tasuta!";

                        }
                        else if (vanus >= 6 && vanus < 14)
                        {
                            pilet = "kinopilet on lastepilet!";
                        }
                        else if (vanus >= 14 && vanus < 65)
                        {
                            pilet = "kinopilet on täispilet!";
                        }
                        else if (vanus >= 65)
                        {
                            pilet = "kinopilet on sooduspilet!";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vanus peab olema positiivne arv ja < kui 100");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                otsus = ("Lähme kinos Jukuga!");
            }
            else
            {
                otsus = "Ei käime kinno";
            }
            vastus = $"{otsus}, Juku {vanus} aastat vana, siis talle pilet on {pilet}";
            return vastus;
        }

        // Remond
        public static int porandPindal(int pikkus1, int pikkus2)
        {
            int porand = pikkus1 * pikkus2;
            return porand;
        }

        public static int remondihinnearvutamine(int pikkus)
        {
            int hind = pikkus * 15;
            return hind;
        }

        public static string temperatuur(int temp)
        {
            string Message1 = "";
            try
            {
                if (temp > 17)
                {
                    Message1 = "Temperatuur on kõigem kui 18 kraadi";
                }
                else if (temp < 18)
                {
                    Message1 = "Temperatuur on vähem kui 18 kraadi";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Message1;
        }

        public static string inimesepikkus(int pikk)
        {
            string message = "";
            try
            {
                if (pikk <= 140)
                {
                    message = "Sa oled lühike";
                }
                else if (pikk > 140 && pikk <= 185)
                {
                    message = "Sa oled keskmine";
                }
                else if (pikk > 185)
                {
                    message = "Sa oled pikk";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return message;
        }

        public static string pikkussugu(string sugu)
        {
            string message = "";
            int pikkus = 0;
            Console.WriteLine("Sisesta pikkus: ");
            pikkus = int.Parse(Console.ReadLine());
            if (sugu == "mees")
            {
                if (pikkus < 140)
                {
                    message = "Sa oled lühike";
                }
                else if (pikkus > 140 && pikkus <= 185)
                {
                    message = "Sa oled keskmine";
                }
                else if (pikkus > 185)
                {
                    message = "Sa oled pikk";
                }
            }
            else if (sugu == "naine")
            {
                if (pikkus <= 130)
                {
                    message = $"Sa oled lühike ja sa oled {sugu}";
                }
                else if (pikkus > 130 && pikkus <= 170)
                {
                    message = $"Sa oled keskmine ja sa oled {sugu}";
                }
                else if (pikkus > 170)
                {
                    message = $"Sa oled pikk ja sa oled {sugu}";
                }
            }

            return message;
        }
    }
}