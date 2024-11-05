using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámTesztOOP
{
    public class SzámTeszt
    {
        private int a;
        private int b;
        private int vegeredmeny;

        public SzámTeszt() { }

        public SzámTeszt(int elsoszam, int masodikszam)
        {
            this.a = elsoszam;
            this.b = masodikszam;
        }

        public void SetSzám1(int szam) => a = szam;
        public void SetSzám2(int szam) => b = szam;

        public void SetEredmény()
        {
            if (a == b) vegeredmeny = 0;
            else if (a > b) vegeredmeny = 1;
            else vegeredmeny = 2;
        }

        public int GetEredmény() => vegeredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SzámTeszt szamTeszt = new SzámTeszt(90, 200);
            szamTeszt.SetEredmény();
            Console.WriteLine("Az eredmény: " + szamTeszt.GetEredmény());
            Console.ReadKey();
        }
    }
}