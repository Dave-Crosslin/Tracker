using System;
using System.Collections.Generic;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{
	
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		
		List<string> comboList = new List<string>();
		comboList.Add ("Dave");
	

		Build ();
	

		foreach (string ID in comboList)
		{
			combobox1.AppendText (ID);

		}

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


}
