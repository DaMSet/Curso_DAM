using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pruebas_Unitarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void devolverstringDiferenteTest()
        {
            bool result = Pruebas_Unitarias.Program.stringDiferente(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." }, new string[] { "Luc ", "yo ", "soy ", "tu ", "padre." });

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void devolverstringDiferenteTest2()
        {
            bool result = Pruebas_Unitarias.Program.stringDiferente(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." }, new string[] { }); 


            Assert.IsFalse (result);
        }
    }


}