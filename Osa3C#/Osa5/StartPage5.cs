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
                default:
                    Console.WriteLine("Valik puudub");
                    break;

            }
        }
    }
}
