using System;
using System.Collections.Generic;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{
	public List<string> comboList = new List<string>();

	public void AddtoCombobox(List<string>comboList);
	{
		foreach (string ID in comboList)
		{
			combobox1.AppendText (ID);

		}
	}
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		

		 
	//

		Build ();
	



	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


}
