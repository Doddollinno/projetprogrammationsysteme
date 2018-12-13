using System;
using System.Data.Common;
using MySql.Data.MySqlClient;
namespace Model {
	public class BDDConnector {

		private static void MySqlConnection()
		{
			string connectionString = GetConnectionString();

			using (MySqlConnection connection = new MySqlConnection())
			{
				connection.ConnectionString = connectionString;

				connection.Open();

				Console.WriteLine("State: {0}", connection.State);
				Console.WriteLine("ConnectionString: {0}",
					connection.ConnectionString);
			}
		}

		static private string GetConnectionString()
		{
			// To avoid storing the connection string in your code, 
			// you can retrieve it from a configuration file.
			return "Data Source=MSSQL1;Initial Catalog=AdventureWorks;"
				+ "Integrated Security=true;";
		}


	}

}
