﻿using System;
using System.Collections.Generic;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{

	public void AddtoCombobox (List<string>row)
	{
		foreach (string ID in row)
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


}
