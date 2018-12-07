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
        /*Utiliser Assert.Fail() avec la doc présent sur stack overflow et trouver un moyen de récupérer la liste des ingrédients
         dans le stock, et l'afficher, je n'ai pas encore trouver de solution pour cela*/

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
            /*Une fois que les tests sont passés, il faut assosier les bons noms, pour ajouter ou supprimer des ingrédients 
             de la base de donné il faudra effectué un test quand la base de donnée sera remplie et connectée. Les tests devraient être
            validée*/
           

        }
    }
}

