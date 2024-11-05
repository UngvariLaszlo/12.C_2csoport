using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulátorOOP
{
    public class Calc
    {
        private double a;
        private double b;
        private char c;
        private double d;

        public Calc() { }

        public Calc(double elsoszam, double masodikszam, char muvelet)
        {
            this.a= elsoszam;
            this.b= masodikszam;
            this.c= muvelet;
        }

        public void SetSzám1(double szam) => a= szam;
        public void SetSzám2(double szam) => b = szam;
        public void SetMűveletJel(char jel) => c = jel;

        public void SetEredmény()
        {
            switch (c)
            {
                case '+': d = a + b; break;
                case '-': d = a - b;break;
                case '*': d = a * b; break;
                case '/': d = b != 0 ? a/ b: 0; break;
                default: throw new InvalidOperationException("A művelet nem helyes");
            }
        }

        public double GetEredmény() => d;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(5, 4, '*');
            calc.SetEredmény();
            Console.WriteLine("Az eredmény: " + calc.GetEredmény());
            Console.ReadKey();
        }

    }
}
