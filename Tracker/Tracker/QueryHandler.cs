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

		

		public List<string> row = new List<string> ();

		private static MySqlConnection connection = new MySqlConnection();

		public string name;

		public void setname(string ID)
		{
			if (ID != "")
			{
				name = ID;
			}
			else 
			{
				name = "error";
			}

		}

		public void ConnectionOpen()
		{
			connection.ConnectionString = "Server=localhost;Database=TestDB;User ID=root;Password=dc;Pooling=false"; 
			connection.Open();
		}

		public void ConnectionClose()
		{
			connection.Close ();
		}
	
		public void QueryCreate(string name)
		{
			string commtext = String.Format ("Select Production from Employees where ID = {0};", name);
		}

	    

		MySqlDataReader Reader;

		public void QueryExecute()
		{	
			MySqlCommand command = connection.CreateCommand ();
			command.CommandText = " SELECT ID FROM Employees GROUP BY ID;";
			Reader = command.ExecuteReader ();

			while (Reader.Read ()) {

				for (int i = 0; i < Reader.FieldCount; i++)
					row.Add (Reader.GetValue (i).ToString ());
				
		   } 

	    }    
	}
}


		
		

