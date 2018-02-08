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
			string commtext = " SELECT ID FROM Employees GROUP BY ID;";
			List<string> row = handler.QueryExecute (commtext);
			win.AddtoCombobox (row);

	
		

			

			win.Show ();
			Application.Run ();

		}
	
	}
}

	
