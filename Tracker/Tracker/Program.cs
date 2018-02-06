using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;



namespace Tracker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();

					
			DBHandler handler = new DBHandler ();
	
		
			handler.ConnectionOpen ();
			handler.QueryExecute ();
			List<string> row = handler.QueryExecute ();
			win.AddtoCombobox (row);

	
		
			/*MySqlConnection connection = new MySqlConnection(); 
			connection.ConnectionString = "Server=localhost;Database=TestDB;User ID=root;Password=dc;Pooling=false"; 
			MySqlCommand command = connection.CreateCommand();
			command.CommandText = " SELECT ID FROM Employees GROUP BY ID;";
			MySqlDataReader Reader;
			connection.Open();
			Reader = command.ExecuteReader();



			while (Reader.Read ()) {
				List<string> row = new List<string> ();
				for (int i = 0; i < Reader.FieldCount; i++)
					row.Add (Reader.GetValue (i).ToString ());
				win.AddtoCombobox (row);
			} 
			
			connection.Close();*/


				
			

			win.Show ();
			Application.Run ();

		}
	
	}
}

	
