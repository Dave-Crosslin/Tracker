using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;
using OxyPlot;
using OxyPlot.GtkSharp;
using OxyPlot.Axes;
using OxyPlot.Series;


namespace Tracker

{
	public class DBHandler
	{ 	
		private static MySqlConnection connection = new MySqlConnection();

		public string name;


		public void ConnectionOpen()
		{
			connection.ConnectionString = "Server=localhost;Database=TestDB;User ID=root;Password=DC;Pooling=false"; 
			connection.Open();
		}

		public void ConnectionClose()
		{
			connection.Close ();
		}

		public string QueryCreate(string name)
		{
			string commtext = String.Format ("SELECT Production, DT FROM Employees WHERE ID = '{0}';", name);
			return commtext;
		}

		public List<string> QueryExecute(string commtext)
		{	
			List<string> row = new List<string> ();

			MySqlCommand command = connection.CreateCommand ();
			command.CommandText = commtext;
			using (MySqlDataReader Reader = command.ExecuteReader ()) {

				while (Reader.Read ()) {

					for (int i = 0; i < Reader.FieldCount; i++) {
						row.Add (Reader.GetValue (i).ToString ());
					}
				} 
			}
			return row;
		}    
	}
}


		
		

