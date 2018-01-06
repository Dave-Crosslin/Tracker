using System;
using System.Collections.Generic;
using System.Data;
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
			win.Show ();
			Application.Run ();

		}
	
	}
}
