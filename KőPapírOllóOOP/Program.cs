using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KőPapírOllóOOP
{
    using System;

    namespace KőPapírOllóOOP
    {
        public class Kpo
        {
            private string a;
            private string b;
            private string eredmeny;

            public Kpo() { }

            public Kpo(string ad1, string ad2)
            {
                this.a = ad1;
                this.b = ad2;
            }

            public void SetTip1(string tip) => a = tip;
            public void SetTip2(string tip) => b = tip;

            public void SetEredmény()
            {
                if (a == b) eredmeny = "Döntetlen lett";
                else if ((a == "Kő" && b == "Olló") || (a == "Papír" && b == "Kő") || (a == "Olló" && b == "Papír"))
                    eredmeny = "Az első játékos nyert";
                else
                    eredmeny = "A második játékos nyert";
            }

            public string GetEredmény() => eredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kpo kpo = new Kpo("Papír", "Kő");
                kpo.SetEredmény();
                Console.WriteLine("Játéknak az eredménye: " + kpo.GetEredmény());
                Console.ReadKey();
            }
        }
    }
}