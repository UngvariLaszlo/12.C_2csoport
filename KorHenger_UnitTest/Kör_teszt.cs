using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor_es_henger;

namespace KorHenger_UnitTest
{
    [TestClass]
    public class Kör_teszt
    {
        [TestMethod]
        public void Kerület_teszt()
        {
            //Arange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör();
            kör.SetKerület();
            double vártEredm = 31.42;

            //Act - Végrehajtás
            kör.SetKerület();
            double kapottEredm = kör.GetKerület();

            //Assert kiértékelés
            Assert.AreEqual(vártEredm, kapottEredm);
        }
        public void Terület_teszt()
        {

        }
    }
}
