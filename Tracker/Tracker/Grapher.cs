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
	public class Grapher
	{   
		public PlotView PV;

		public Grapher ()
		{
		}
	


		public PlotView CreateGraph(DBHandler Handler, Dictionary<Int64,int>dictionary)
		{ 
			string title = Handler.name;

			var plotView = new PlotView();
			plotView.ShowAll();

			var myModel = new PlotModel { Title = title };
			var s1 = new LineSeries ()
			{
				Color = OxyColors.Blue,
				MarkerType = MarkerType.Circle,
				MarkerSize = 6,
				MarkerStroke = OxyColors.Black,
				MarkerFill = OxyColors.Red,
				MarkerStrokeThickness = 3
			};
			foreach (var pair in dictionary) {
				s1.Points.Add (new DataPoint (pair.Key, pair.Value));
			}
		
			myModel.Series.Add(s1);
			plotView.Model = myModel;

			return plotView;
		}

		public void RedrawGraph (Grapher graph, VBox vbox1)
		{
			if (graph.PV != null) {
				vbox1.Remove (graph.PV);
			}
		}

		public Dictionary<Int64,int> Parser(List<string>row)
		{   
			DateTime formatDT = new DateTime ();
			Int64 myDT = 0;
			int myInt = 0;
			
			 
			Dictionary<Int64,int> dictionary = new Dictionary<Int64,int>();

			foreach (string str in row) {
				if (str.Contains (':')) {
					
					formatDT = Convert.ToDateTime (str);

					myDT = Int64.Parse(formatDT.ToString("HHmm"));


				} else {
					
					myInt = Convert.ToInt32(str);
				}
		     }
			dictionary.Add (myDT, myInt);
			return dictionary;
		}
	}
}
	



