using System;
using System.Collections.Generic;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

namespace Tracker
{
	public class QueryHandler
	{
		MySqlCommand command = MySqlConnection.CreateCommand();

		public void QueryCreate ()
		{	
			string query = "\"SELECT ID FROM Employees GROUP BY ID;\""
		}

		public void QueryExecute ()
		{
			
			MySqlDataReader Reader;
			Reader = command.ExecuteReader();


		}

		public void QueryStore ()
		{
			//to write to strings, lists, GUI, ect.
		}

	}
		
}

