﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kraj, vrijednostPrva, vrijednostDruga, rezultat;

            vrijednostPrva=rezultat=0;
            vrijednostDruga=1;

            Console.Write("Upisi kraj Fibonaccijevog niza : ");
            kraj=Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Fibonaccijev niz : ");
            for (int i=1; i<=kraj; i++)
            {
                if (i==1)
                {
                    Console.Write(vrijednostPrva + " ");
                }
                if (i==2)
                {
                    Console.Write(vrijednostDruga + " ");
                }

                rezultat=vrijednostPrva+vrijednostDruga; 
                vrijednostPrva=vrijednostDruga; 
                vrijednostDruga=rezultat; 

                Console.Write(rezultat + " ");
            }
            Console.WriteLine("Broj koji je " + kraj + ". po redu u Fibonaccijevom nizu je: " + rezultat + ".");


            Console.ReadKey();
        }
    }
}
