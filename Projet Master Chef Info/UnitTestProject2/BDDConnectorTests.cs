using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tests
{
    [TestClass()]
    public class BDDConnectorTests
    {
        [TestMethod()]
        public void GetAllStockTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFromStockTest()
        {
            int a = 5;
            int b = 1;
            int c = a - b;
            Console.WriteLine(c);

            int d = 14;
            int e > 2;
            int f = d - e;
            Console.WriteLine(f);
        }


        [TestMethod()]
        public void AddFromStockTest()
        {
            int a = 7;
            int b = 1;
            int c = a + b;
            Console.WriteLine(c);

            int d = 14;
            int e > 2;
            int f = d + e;
            Console.WriteLine(f);

        }
    }
}

