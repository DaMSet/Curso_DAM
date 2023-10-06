using Microsoft.VisualStudio.TestTools.UnitTesting;
using T2_E6b_LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E6b_LINQ.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void getn7Test()
        {

            List<int> l = Program.getn7();

            List<int> lista = new List<int>
            {
                7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98
            };

            CollectionAssert.AreEqual(l,lista);
        }
    }
}