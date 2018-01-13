using System;
using System.Collections.Generic;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

namespace Tracker
{
	public class ConnectionHandler
	{   
		MySqlConnection connection = new MySqlConnection("Server=localhost;Database=TestDB;User ID=root;Password=dc;Pooling=false"); 

		public void DBConnOpen ()
		{
			
			//connection.ConnectionString = "Server=localhost;Database=TestDB;User ID=root;Password=dc;Pooling=false"; 
			connection.Open();

		}
	
		public void DBConnClose ()
		{
			connection.Close ();
		}
	
	}
}

