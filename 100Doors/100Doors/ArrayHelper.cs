using System;

namespace Doors
{
	public class ArrayHelper
	{
		public ArrayHelper ()
		{
		}

		public T[] InitializeArray<T>(int length) where T : new()
		{
			T[] array = new T[length];
			for (int i = 0; i < length; ++i)
			{
				array[i] = new T();
			}

			return array;
		}


		public void VisitDoors(Door[] DoorArray)
		{
			for (int j = 1; j < DoorArray.Length; j++) {

				for (int i = j; i < DoorArray.Length; i += j) {

					Console.WriteLine ("door {0} is {1}", i, DoorArray [i].Status ());
				 }
			 }
		 }

		
			public void StatusReport(Door[] DoorArray)
			{
			for(int i = 1; i < DoorArray.Length; i++)
			{
				if(DoorArray[i].toggle == true){
					Console.WriteLine("Door {0} is Open", i);
					}
			}
		}
	}
}

