using System;

namespace Doors
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			
			ArrayHelper helper = new ArrayHelper ();
			Door[] DoorArray = helper.InitializeArray<Door> (101);
			helper.VisitDoors (DoorArray);
			helper.StatusReport (DoorArray);

		}
	}
}
