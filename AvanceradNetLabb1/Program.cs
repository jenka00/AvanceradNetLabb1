using System;
using System.Collections;
using System.Collections.Generic;

namespace AvanceradNetLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection lådor = new LådaCollection();
            lådor.Add(new Låda(5, 5, 5));
            lådor.Add(new Låda(10, 10, 10));
            lådor.Add(new Låda(3, 5, 8));
            lådor.Add(new Låda(4, 2, 6));
            lådor.Add(new Låda(15, 2, 1));

            lådor.Add(new Låda(10, 10, 10));

            Console.WriteLine("---------------------------------------------------------------------");
            Display(lådor);

            Console.ReadKey();

            lådor.Remove(new Låda(10, 10, 10));
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Tagit bort låda med måtten 10 x 10 x 10");

            Display(lådor);

            Console.ReadKey();

            Låda lådaFinns = new Låda(3, 5, 8); 
            Console.WriteLine("Listan innehåller låda med måtten {0} x {1} x {2} = {3}",
                lådaFinns.höjd, lådaFinns.längd, lådaFinns.bredd, lådor.Contains(lådaFinns).ToString());

        }

        public static void Display(LådaCollection lådLista)
        {
            foreach (Låda låda in lådLista)
            {
                Console.WriteLine($"Höjd = {låda.höjd}, bredd = {låda.bredd}, längd = {låda.längd}");
                Console.WriteLine("-----------------------------------------------------------------");
            }   
        }
    }
}
