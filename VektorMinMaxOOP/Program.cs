using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMinMaxOOP
{
    public class VektorMinMax
    {
        private int[] vektorok;
        private int kisebb;
        private int kisebbIndex;
        private int nagyobb;
        private int nagyobbIndex;

        public VektorMinMax() { }

        public VektorMinMax(int[] vektor)
        {
            SetVektor(vektor);
        }

        public void SetVektor(int[] vektor)
        {
            this.vektorok = vektor;
            SetMin();
            SetMax();
        }

        public void SetMin()
        {
            kisebb = vektorok.Min();
            kisebbIndex = Array.IndexOf(vektorok, kisebb);
        }

        public void SetMax()
        {
            nagyobb = vektorok.Max();
            nagyobbIndex = Array.IndexOf(vektorok, nagyobb);
        }

        public (int, int) GetMin() => (kisebb, kisebbIndex);
        public (int, int) GetMax() => (nagyobb, nagyobbIndex);

        public (int, int)[] GetMinMax() => new[] { (kisebb, kisebbIndex), (nagyobb, nagyobbIndex) };
    }

    class Program
    {
        static void Main(string[] args)
        {
            VektorMinMax vektorMinMax = new VektorMinMax(new[] { 7, 8, 3, 9, 2, 5 });
            Console.WriteLine("A legkisebb elem és sorszáma:: " + vektorMinMax.GetMin());
            Console.WriteLine("A legnagyobb elem és sorszáma: " + vektorMinMax.GetMax());
            Console.ReadKey();
        }
    }
}