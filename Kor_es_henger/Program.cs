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
            Kor k1 = new Kor();
            k1.SetSugar(15);
            k1.GetTerület();
            k1.GetKerület();

            kiír(k1);

            //2.pédány

            Kor k2 = new Kor(58);
            k2.GetKerület();
            k2.GetTerület();

            kiír(k2);
            Console.ReadKey();
        }

        private static void kiír(Kor k)
        {
            Console.WriteLine($"A {k.GetSugar()} sugarú kör területe: {k.GetKerület()}, területe{k.GetTerület()}");

        }
    }
}
