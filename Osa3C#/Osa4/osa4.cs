using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;

namespace Osa3C_.Osa4
{
    public class osa4
    {
        // FailiKirjutamine
        public static void FailiKirjutamine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
                Console.WriteLine(path);
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();

                /* Siis pead kindlasti faili sulgema, näiteks:

                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Midagi");
                sw.Close(); // Vajalik!


                Või parem lahendus:

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Midagi");
                } // Fail suletakse automaatselt siin */

            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        // FailiLugemine
        public static void FailiLugemine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        // RidadeLugemine
        public static void RidadeLugemine()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }

        public static void ListiMuutmineJaKuvamine()
        {

            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

            kuude_list.Remove("Juuni");

            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }

        public static void otsiNimekirjast()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");
        }
        /* Listi salvestamine tagasi faili

        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
        File.WriteAllLines(path, kuude_list);
        Console.WriteLine("Andmed on salvestatud.");*/ 


        /*💡 Parimad praktikad

            Kasuta Path.Combine failitee määramisel – töötab igas süsteemis.

            Faili olemasolu kontroll:

            if (!File.Exists(path)) File.WriteAllLines(path, new string[] { "Jaanuar", "Veebruar", "Märts" });

            Sulge failid alati(või kasuta using plokki).*/

        /*✅ Õppematerjali kokkuvõte
            Oskus Õpitud tegevus
            Failikirjutus   StreamWriter, WriteLine()
            Faililugemine StreamReader, ReadToEnd(), File.ReadAllLines()
            Vigade käsitlemine 	try-catch
            Andmestruktuurid List<string>, lisamine, muutmine, kustutamine
            Failitee kasutamine Path.Combine, AppDomain.CurrentDomain.BaseDirectory
            Otsing ja salvestus     Contains(), WriteAllLines()*/
    }
}
