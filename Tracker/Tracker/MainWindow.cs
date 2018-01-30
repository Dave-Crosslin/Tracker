﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;
using Tracker;

public partial class MainWindow: Gtk.Window
{   DBHandler handler; 

	string ID;
    
	public void GetActiveText(string ID)
	{
		if (ID != "") { 
			handler.name = ID;
		} else {
			handler.name = "error";
		}
	}

	public void SetDBHandler(DBHandler handler)
	{
		this.handler = handler;

	}

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

		/*ID = combobox1.ActiveText;
		GetActiveText(ID);*/
		Console.WriteLine (combobox1.ActiveText);

	}
 


}

