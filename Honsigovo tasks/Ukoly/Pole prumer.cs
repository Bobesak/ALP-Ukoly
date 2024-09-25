using System;
using System.Linq;

namespace PrumerCisel
{

    class PocetCisel
    {
        static int pocetciselcelkove;
        static int[] cisla;
        static int cislo;
        static int i;
        
        
        public static void Start()
        {
            Console.WriteLine("Kolik cisel chcete zadat?");
            pocetciselcelkove = int.Parse(Console.ReadLine());
            int[] cisla = new int[pocetciselcelkove];
            Console.WriteLine("muzete zacit, pokud chcete ukoncit proces napiste konec");
            for (int i = 0; i < pocetciselcelkove; i++)
            {
                ZadavaniCisel();
                cisla[i] = cislo;
                Console.WriteLine(i);
            }

            double Average = cisla.Average();
            Console.WriteLine("prumer cisel je :" + Average);
            Console.ReadKey();

        }

        static void ZadavaniCisel()
        {
            string input;
            Console.WriteLine("Cislo? 1-5");
            input = Console.ReadLine();
            if (input == "Konec" || input == "konec")
            {
                i = 10;
            }
            while (int.Parse(input) < 1 || int.Parse(input) > 5)
            {
                Console.WriteLine("Neplatne cislo");
                Console.WriteLine("Cislo? 1-5");
                input = Console.ReadLine();
            }
            cislo = int.Parse(input);
            
        }


    }





}