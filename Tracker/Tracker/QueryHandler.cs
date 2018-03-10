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

		public Dictionary<Int64,int>QueryExecute(string commtext) 
		{	
			DateTime formatDT = new DateTime ();
			Int64 myDT = 0;
			int myInt = 0;

			Dictionary <Int64, int> Dict = new Dictionary<Int64,int>();
			List<string> row = new List<string> ();

			MySqlCommand command = connection.CreateCommand ();
			command.CommandText = commtext;
			using (MySqlDataReader Reader = command.ExecuteReader ()) {

				while (Reader.Read ()) {

					for (int i = 0; i < Reader.FieldCount; i++) {
						row.Add (Reader.GetValue (i).ToString ());
					}
				} 

			/*The above while loop is definitely only giving me one List that contains data from many rows in my DB,
			 * it is not giving me multiple lists called row that I can just parse by doing (row[0]) (row([1])
			 * in the code below. The only solution I can see is to parse the info in row to two separate lists, 
			 * then use a zip function to combine the lists to my dictionary. Let me know what you think and if 
			 * I'm missing something here, thank you*/

			formatDT = Convert.ToDateTime (row[1]);
			myDT = Int64.Parse(formatDT.ToString("HHmm"));
			myInt = Convert.ToInt32(row[0]);
			Dict.Add(myDT,myInt);
			
			return Dict;
		}    
	}

			public List <string> comboboxFill(string commtext)
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
	
	
	


		
		

