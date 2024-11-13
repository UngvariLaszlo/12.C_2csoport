using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace KörHenger
{
    class Kör
    {
        protected double sugar,
            terület,
            kerület;
 
        public Kör() { }
 
        public Kör(double r)
        {
            this.sugar = r;
        }
 
        public void SetSugar(double r)
        {
            this.sugar = r;
        }
 
        public void SetTerület()
        {
            this.terület = Math.Round(Math.Pow(this.sugar, 2) * Math.PI, 2);
        }
 
        public void SetKerület()
        {
            this.kerület = Math.Round(2 * this.sugar * Math.PI, 2);
        }
 
        public double GetTerület()
        {
            return this.terület;
        }
 
        public double GetKerület()
        {
            return this.kerület;
        }
 
        public double GetSugár()
        {
            return this.sugar;
        }
    }
 
    class Henger : Kör
    {
        // Osztályváltozók
        private double térfogat,
            magasság;
 
        // Konstruktor
        public Henger(double s, double m)
        {
            // Változók beállítása
            this.sugar = s;
            this.magasság = m;
 
            // Számítások elvégzése
            SetKerület();
            SetTerület();
            this.térfogat = this.terület * this.magasság;
        }
 
        public double GetTérfogat()
        {
            return this.térfogat;
        }
 
    }
}
