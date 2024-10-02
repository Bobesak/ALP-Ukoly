namespace Catchukol
{
    class Catch
    {
        static void HlavniCatch()
        {

            try
            {
                Console.WriteLine("Zadejte cislo");
                int cislo = int.Parse(Console.ReadLine());
                Console.WriteLine("druha mocnina je : " + cislo * cislo);

            }
            catch (FormatException e)
            {
            }
            catch (OverflowException)
            {
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
                
            }


        }
    }
}