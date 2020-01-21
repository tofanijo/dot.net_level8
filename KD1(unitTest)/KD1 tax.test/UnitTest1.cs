using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KD1_unitTest_;

namespace KD1_tax.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FunkcijaApverstiSakyni_TuriApverstiSakyni()
        {
            //Arange
            string sakinysnr1 = "abc";
            //Act
            string rezultatas = Program.ApverstiSakini(sakinysnr1);
            //Asert
            Assert.AreEqual(rezultatas, "cba");
        }
        [TestMethod]
        public void FunkcijaApverstiSakyniSuTusciaReiksme_TuriGRazintiTusciaReiksme()
        {
            //Arange
            string sakinysnr1 = "";
            //Act
            string rezultatas = Program.ApverstiSakini(sakinysnr1);
            //Asert
            Assert.AreEqual(rezultatas, "");
        }
        [TestMethod]
        public void FunkcijaApverstiSakyniSuTarpu_TuriGRazintiTarpa()
        {
            //Arange
            string sakinysnr1 = " ";
            //Act
            string rezultatas = Program.ApverstiSakini(sakinysnr1);
            //Asert
            Assert.AreEqual(rezultatas, " ");
        }
    }
}
