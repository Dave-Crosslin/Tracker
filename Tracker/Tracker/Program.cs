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
using Google.Protobuf;
using Grpc.Core;

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
			List<string> row = handler.comboboxFill (commtext);
			win.AddtoCombobox (row);

			ServerHandler Server = new ServerHandler ();
			Server.StartServer ();

	

			

			win.Show ();
			Application.Run ();

		}
	}
}

	
