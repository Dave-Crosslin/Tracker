using System;

namespace Doors
{
	public class Door
	{
		public bool toggle = false;

		public string status;


		public Door ()
		{
			
		}
			

		public string Status()
		{
			if (toggle == false) {
				toggle = true;
			} else if (toggle == true) {
				toggle = false;
			}
			if (toggle == false) {
				 status = "Closed";
			} else if (toggle == true) {
				 status = "Open";
			} 

			return status;
		}
	}
}

