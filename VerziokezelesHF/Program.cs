using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerziokezelesHF
{
    class Program
    {
        static void Main(string[] args)
       {
            //1.Hozz létre egy üres, konzolos projektet VerzioKezelesHF néven.
            //2.Olvass be a felhasználótól 10 számot, számold ki az átlagukat!
            //3.Módosítsd a programot, hogy a felhasználó adhassa meg, hány számot írjon be!
            //4.Számold ki a számok közül a legnagyobbat és a legkisebbet!
            //A részfeladatok külön commitban szerepeljenek! Vagyis:


            Console.WriteLine("Ez egy szám bekérös program");
            int szamindex = 10;
            Console.WriteLine("adja meg hány számot szeretne meg adni");
            szamindex= Convert.ToInt32(Console.ReadLine()); 
            int[] szambe = new int[szamindex];
            for (int i = 0; i < szamindex; i++)
            {
                Console.WriteLine("adja meg az " + (i+1) + ". számot");
                szambe[i] = Convert.ToInt32(Console.ReadLine());
            }


            int minimum=szambe[1];
            int maximum=szambe[1];

            for (int i = 0; i < szamindex; i++)
            {
                if (szambe[i]<minimum)
                {
                    minimum = szambe[i];
                }
                if (szambe[i]>maximum)
                {
                    maximum = szambe[i];
                }
            }


            Console.WriteLine(szambe.Average());
            Console.WriteLine("maximum:"+maximum);
            Console.WriteLine("minimum:"+minimum);


            Console.ReadKey();
        }
    }
}
