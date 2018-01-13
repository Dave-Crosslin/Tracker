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

		public void QueryExecute ()
		{
			MySqlDataReader Reader;
			Reader = command.ExecuteReader();

			while (Reader.Read())
			{
				List<string> row = new List<string>();
				for (int i = 0; i < Reader.FieldCount; i++)
			{
		}
	
				public void QueryCreate()
		{	
			MySqlCommand command = MySqlConnection.CreateCommand(" SELECT ID FROM Employees GROUP BY ID;");
		}

	}
}
