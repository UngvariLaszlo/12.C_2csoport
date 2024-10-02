using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teszt12.C_2csoport_UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static void TestMethod1()
        {
            //Arange: Beállítások és várt eredmény
            string vartEredm = "Hello world";
            //Act: A tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                test.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                //Assert:Kiértékelés
                Assert.AreEqual(vartEredm, kapottEredm);
                
            } 
        }
    }
}
