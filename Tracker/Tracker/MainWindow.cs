using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Gtk;
using MySql.Data.MySqlClient;
using Tracker;

public partial class MainWindow: Gtk.Window
{  DBHandler Handler = new DBHandler();


    

	public void SetDBHandler(DBHandler Handler)
	{
		this.Handler = Handler;

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
		
	private void OnCombobox1Changed (object sender, EventArgs e)
	{

		Handler.name = combobox1.ActiveText;
		string commtext = Handler.QueryCreate (Handler.name);
		List<string> row = Handler.QueryExecute2 (commtext);

		foreach (String ID in row) {
			Console.WriteLine (ID);

		}



	}
 


}

