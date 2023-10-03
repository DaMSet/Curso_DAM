using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1_PilasYColas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PilasYColas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void comprobarFormulaTest()
        {
            bool comprobar = Ejercicio1_PilasYColas.Program.comprobarFormula(new string("(2+[3-12]*{8/3})"));

            Assert.IsTrue(comprobar);
        }

        [TestMethod()]
        public void comprobarFormulaTest2()
        {
            bool comprobar = Ejercicio1_PilasYColas.Program.comprobarFormula(new string("(2+[3-12]*{8/3}}"));

            Assert.IsFalse(comprobar);
        }
    }
}