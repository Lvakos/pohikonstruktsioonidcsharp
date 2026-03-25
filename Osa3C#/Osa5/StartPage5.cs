using System;
using System.Collections.Generic;
using System.Text;

namespace Osa3C_.Osa5
{
    internal class start_page_osa5
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("osa5 funktsioonid");
            string valik = Console.ReadLine();
            switch (valik)
            {
                // C# Andmestruktuurid ja nendega töötamine
                case "1":
                    osa5_funktsioonid.array_naide();
                    break;
                case "2":
                    osa5_funktsioonid.Tuple();
                    break;
                case "3":
                    osa5_funktsioonid.List_klassiga();
                    break;
                case "4":
                    osa5_funktsioonid.LinkedList();
                    break;
                case "5":
                    osa5_funktsioonid.sonatlik();
                    break;
                // Ülesanded

                case "6":
                    ulesanded.KalooriteKalk();
                    break;
                case "7":
                    ulesanded.maakondJapealinnad();
                    break;

                case "8":
                    List<opilane> opilased = new List<opilane>();

                    for (int i = 0; i < 3; i++)
                    {
                        try
                        {
                            List<int> hinded = new List<int>();
                            Console.Write("Sisesta õpilase nimi: ");
                            string nimi = Console.ReadLine();
                            for (int j = 0; j < 5; j++)
                            {

                                Console.Write("Sisesta õpilase hinded (1-5): ");
                                int hinne = int.Parse(Console.ReadLine());
                                if (hinne > 1 || hinne < 5)
                                {
                                    hinded.Add(hinne);
                                }
                                else
                                {
                                    Console.WriteLine("Hinded peab olema vahemikus 1-5");
                                }

                            }
                            opilane uus_opilane = new opilane(nimi, hinded);
                            opilased.Add(uus_opilane);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Vale andmed");

                        }

                    }
                    ulesanded.opilased(opilased);
                    break;



                case "9":
                    ulesanded.Tekstist_arvud();
                    break;

                case "10":
                    ulesanded.Lemmikloomade_register();
                    break;

                case "11":
                    ulesanded.ValuteCalculator();
                    break;

                default:
                    Console.WriteLine("Valik puudub");
                    break;

            }
        }
    }
}
