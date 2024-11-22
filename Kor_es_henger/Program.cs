using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor_es_henger
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. pédány
            Kör k1 = new Kör();
            k1.SetSugar(15);
            k1.GetTerület();
            k1.GetKerület();

           // kiír(k1);

            //2.pédány

            Kör k2 = new Kör(58);
            k2.GetKerület();
            k2.GetTerület();

            //kiír(k2);


            //1.henger
            try
            {
                Henger h1 = new Henger(15, 34);
                kiírHenger(h1);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine($"Aritmetikai hiba {e.Message}!");
            }

            try
            {
                Henger h2 = new Henger(-1, 30);
                kiírHenger(h2);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            
            
            
            
            




            Console.ReadKey();
        }

        private static void kiír(Kör k)
        {
            Console.WriteLine($"A {k.GetSugár()} sugarú kör területe: {k.GetKerület()}, területe{k.GetTerület()}");

        }

        private static void kiírHenger(Henger k)
        {
            Console.WriteLine($"A {k.GetSugár()} sugarú kör területe: {k.GetKerület()}, területe{k.GetTerület()}, térfogata:{k.GetTérfogat()}.");

        }
    }
}
