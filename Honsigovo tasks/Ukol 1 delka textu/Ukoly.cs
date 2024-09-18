using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ukoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyber si ukol: ");
            Console.WriteLine("1. Delka textu");
            Console.WriteLine("2. Soucet desetinnych cisel");
            int UserChoice;
            UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    StringLength();
                    break;
                case 2:
                    FloatSoucet();
                    break;
                default:
                    Console.WriteLine("Zadal jsi spatnou volbu");
                    break;
            }
        }
        
        static void StringLength()
        {
           string UserEntry;
           Console.WriteLine("Napis text");
           UserEntry = Console.ReadLine();
           string trimmedtext;
           trimmedtext = UserEntry.Replace(" ", "");
           int txtlength = trimmedtext.Length;
           Console.WriteLine("Pocet znaku je : " + txtlength);
           Console.ReadKey(); 
         }
        
        static void FloatSoucet()
        {
            float UserEntryFloat1;
            float UserEntryFloat2;
            Console.WriteLine("Napis prvni cislo");
            UserEntryFloat1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Napis druhe cislo");
            UserEntryFloat2 = float.Parse(Console.ReadLine());
            float soucet = UserEntryFloat1 + UserEntryFloat2;
            soucet = (float)Math.Round(soucet, 2);
            
            Console.WriteLine("Soucet dvou desetinnych cisel je: " + soucet);
            Console.ReadKey();
            
        }
    }
}




