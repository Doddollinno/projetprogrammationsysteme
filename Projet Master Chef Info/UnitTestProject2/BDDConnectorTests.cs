using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Model.Tests
{

    [TestClass()]
    public class BDDConnectorTests
    {
        MySqlConnection MLD = new MySqlConnection("datasource=Localhost;port=3306;username=root;password='' ;database=MLD");
        MySqlCommand Command = new MySqlCommand();
        MySqlDataReader Read;


        [TestMethod()]
        public void GetAllStockTest()
        {
            /* A vérifier
            Command.CommandText = "UPDATE chambre_froide SET Quantite = Quantite-1 WHERE Nom= 'Crabe' ";
            Read = Command.ExecuteReader();
            */

        }


        [TestMethod()]
        public void DeleteFromStockTest()
        {

            Command.CommandText = "UPDATE chambre_froide SET Quantite = Quantite-1 WHERE Nom= 'Crabe' ";
            Read = Command.ExecuteReader();
            Command.CommandText = "UPDATE chambre_froide SET Quantite = Quantite-4 WHERE Nom= 'Escargot' ";
            Read = Command.ExecuteReader(); 

        }
        /*Cette méthode permet de supprimer de la BDD un élément présent et disponible qui sera utiliser*/


        [TestMethod()]
        public void AddFromStockTest()
        {

            Command.CommandText = "UPDATE chambre_froide SET Quantite = Quantite+1 WHERE Nom= 'Crabe' ";
            Read = Command.ExecuteReader();
            Command.CommandText = "UPDATE chambre_froide SET Quantite = Quantite+4 WHERE Nom= 'Escargot' ";
            Read = Command.ExecuteReader();

        }
        /*Cette méthode permet d'ajouter à la BDD un nouvel élément */

        /* Création des méthodes pour le matériel utilisé (à mettre ou non dans la BDD)

        [TestMethod()]
        public void AddMaterielFromStockTest()
        {
            



        }



        [TestMethod()]
        public void DeleteMaterielFromStockTest()
        {


        }
        */

    }
}

