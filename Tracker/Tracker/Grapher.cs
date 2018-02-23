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
	


		public PlotView CreateGraph(DBHandler Handler)
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
			s1.Points.Add(new DataPoint(0, 10));
			s1.Points.Add(new DataPoint(10, 40));
			s1.Points.Add(new DataPoint(40, 20));
			s1.Points.Add(new DataPoint(60, 30));
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
	}
}
	



