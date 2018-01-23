using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{   DBHandler dbhandler; 
	public void SetDBHandler(DBHandler dbhandler)
	{
		this.dbhandler = dbhandler;

	}
	public string Name;

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
		
	protected void OnCombobox1Changed (object sender, EventArgs e)
	{
		
		Query = combobox1.ActiveText;

	}
}
