using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;

namespace Tracker
{
	public class DBHandler
	{ 	
		MySqlConnection connection = new MySqlConnection(); 

		public void ConnectionOpen()
		{
			connection.ConnectionString = "Server=localhost;Database=TestDB;User ID=root;Password=dc;Pooling=false"; 
			connection.Open();
		}

		public void ConnectionClose()
		{
			connection.Close ();
		}
	
		public void QueryCreate()
		{
			
		}

	    MySqlCommand command = connection.CreateCommand();

		MySqlDataReader Reader;

		public void QueryExecute()
		{	
			//MySqlCommand command = connection.CreateCommand ();
			command.CommandText = " SELECT ID FROM Employees GROUP BY ID;";
			Reader = command.ExecuteReader();

			while (Reader.Read ()) {
				List<string> row = new List<string> ();
				for (int i = 0; i < Reader.FieldCount; i++)
					row.Add (Reader.GetValue (i).ToString ());
				QueryStore(row);
			} 
		}


		public void QueryStore(List<string>Row)
		{

		}
	}
}

		
		

