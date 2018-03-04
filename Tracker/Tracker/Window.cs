using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;
using Tracker;
using OxyPlot;
using OxyPlot.GtkSharp;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Tracker
{
	public partial class MainWindow : Gtk.Window
	{

		public static DBHandler Handler = new DBHandler();
		Grapher graph = new Grapher();



		/*public void SetDBHandler(DBHandler Handler)
		{
			this.Handler = Handler;
		} */



		public void AddtoCombobox (List<string>row)
		{
			foreach(string ID in row)
			{
				combobox1.AppendText (ID);

			}
		}


		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnCombobox1Changed (object sender, EventArgs e)
		{

			Handler.name = combobox1.ActiveText;
			string commtext = Handler.QueryCreate (Handler.name);
			List<string> row = Handler.QueryExecute (commtext);
			Dictionary<DateTime,int> dictionary = graph.Parser (row);
			foreach (var item in dictionary) {
				Console.WriteLine (item.Key +" " + item.Value );
			}


			graph.RedrawGraph (graph, vbox1);
			graph.PV = graph.CreateGraph (Handler);

			vbox1.Add (graph.PV);




		}
	}
}