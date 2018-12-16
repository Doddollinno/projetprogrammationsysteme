using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace TestController
{
    [TestClass]
    public class TestTimemanager
    {
        private readonly TimeManager timemanager = new TimeManager();
    
        [TestMethod]
        public void Test()
        {
            int t = 180;
            int temps = timemanager.Seconde + t;
            if (temps == 0)
            {
                Console.WriteLine("Le test est bon");
            }

        }


    }
}
