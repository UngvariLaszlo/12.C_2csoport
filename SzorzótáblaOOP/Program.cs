using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzorzótáblaOOP
{
    namespace SzorzótáblaOOP
    {
        public class Szorzótábla
        {
            private int a;
            private int[] vegeredmeny;

            public Szorzótábla() { }

            public Szorzótábla(int szam) => SetSzam(szam);

            public void SetSzam(int szam)
            {
                if (szam >= 1 && szam <= 9)
                {
                    this.a = szam;
                    SetEredmény();
                }
            }

            public void SetEredmény()
            {
                vegeredmeny = new int[10];
                for (int i = 1; i <= 10; i++)
                {
                    vegeredmeny[i - 1] = a * i;
                }
            }

            public int[] GetEredmény() => vegeredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Szorzótábla szorzotabla = new Szorzótábla(8);
                int[] eredmeny = szorzotabla.GetEredmény();
                Console.WriteLine("Szorzótábla:");
                foreach (var elem in eredmeny) Console.WriteLine(elem);
                Console.ReadKey();
            }
        }
    }
}
