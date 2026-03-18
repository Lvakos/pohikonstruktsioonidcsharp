using System;
using System.Collections;
using System.Collections.Generic;

namespace Osa3C_.Osa5
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class osa5_funktsioonid
    {
        public static void List_klassiga()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Kadi" },
                new Person { Name = "Marju" }
            };

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void Remove_Listist()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Kadi" },
                new Person { Name = "Mirje" }
            };

            people.RemoveAll(p => p.Name == "Kadi");

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void Insert_Listisse()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Kadi" },
                new Person { Name = "Mirje" }
            };

            people.Insert(1, new Person { Name = "Juku" });

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void osting_findindex()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Kadi" },
                new Person { Name = "Mirje" }
            };

            Console.WriteLine($"Kadi index on: {people.FindIndex(p => p.Name == "Kadi")}");

            people.RemoveAll(p => p.Name == "Kadi");
        }

        public static void remove_objekt()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Kadi" },
                new Person { Name = "Mirje" }
            };

            people.RemoveAll(p => p.Name == "Mirje");

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        public static void array_naide()
        {
            ArrayList nimed = new ArrayList
            {
                "Kati",
                "Mati",
                "Juku"
            };

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            nimed.Sort();

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }

        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        public static void LinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            Console.WriteLine("---------------------------------------------");

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);

            Console.WriteLine("---------------------------------------------");

            LinkedListNode<int> node = loetelu.Find(5);
            loetelu.AddBefore(node, 11);
            loetelu.AddAfter(node, 22);
        }

        public static void sonatlik()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>
            {
                { 1, "Hiina" },
                { 2, "Eesti" },
                { 3, "Itaalia" }
            };

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string riik = riigid[2];
            Console.WriteLine($"Võtme 2 riik on: {riik}");

            riigid[2] = "Eestimaa";

            riigid.Remove(3);

            Console.WriteLine("Pärast uuendamist ja eemaldamist:");
            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");
        }

        public static void sonatlikKlassiga()
        {
            Dictionary<char, Person> inimesed = new Dictionary<char, Person>
            {
                { 'k', new Person { Name = "Kadi" } },
                { 'm', new Person { Name = "Mait" } }
            };

            inimesed.Add('j', new Person { Name = "Juku" });

            inimesed['m'] = new Person { Name = "Marju" };

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }
    }
}