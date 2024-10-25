using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor_es_henger
{
    class Kor
    {
        //Az osztaly feladata egy kör területének és kerületének kiszámítása.

        //Osztályváltozók deklarálása
        private double sugar, kerület, terület;

        //Konstruktorok
        public Kor()
        {

        }

        public Kor(double r)
        {
            setDatas(r);
        } 
        private double kalkKerület(double r)
        {
            return Math.Round( 2 * r * Math.PI,2);
        }

        private double kalkTerület(double r)
        {
            return Math.Round(Math.Pow(r, 2) * Math.PI,2);
        }

        public double GetSugar() { return this.sugar; }
        public double GetKerület() { return this.kerület; }
        public double GetTerület() { return this.terület; }
        public void SetSugar(double r)
        {
            this.sugar = r;
            this.kerület = kalkKerület(r);
            this.terület = kalkTerület(r);
        }
        private void setDatas(double r)
        {
            this.sugar = r;
            this.kerület = kalkKerület(r);
            this.terület = kalkTerület(r);
        }
    }
}
