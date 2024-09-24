using System;

namespace PrumerCisel
{

    class PocetCisel
    {
        static int pocetciselcelkove;
        static int[] cisla;
        static int cislo;
        static int i;
        
        
        static void Main(String[] args)
        {
            Console.WriteLine("Kolik cisel chcete zadat?");
            pocetciselcelkove = int.Parse(Console.ReadLine());
            int[] cisla = new int[pocetciselcelkove - 1];
            Console.WriteLine("muzete zacit, pokud chcete ukoncit proces napiste konec");
            for (int i = 0; i < pocetciselcelkove; i++)
            {
                ZadavaniCisel();
                cisla[i] = cislo;
            }
            Console.WriteLine(cisla);
            
        }

        static void ZadavaniCisel()
        {
            string input;
            Console.WriteLine("Cislo?");
            input = Console.ReadLine();
            if (input == "Konec")
            {
                i = 10;
            }
            else if (input == "konec")
            {
                i = 10;
            }
            else
            {
                cislo = int.Parse(input);
            }

            
            
            
            
            
            

        }


    }





}