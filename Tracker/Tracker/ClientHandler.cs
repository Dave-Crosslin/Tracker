using System;
using Grpc.Core;
using TrackerRPC;
using Google.Protobuf.WellKnownTypes;

namespace Tracker
{
	public class ClientHandler
	{
		public ClientHandler ()
		{

		}

		public void ClientService(){
			Channel channel = new Channel ("127.0.0.1:50051", ChannelCredentials.Insecure);
			var client = new dbUpdate.dbUpdateClient (channel);

			string ID = "Josh";
			int production = 3000;
			Timestamp timeStamp = Timestamp.FromDateTime (DateTime.UtcNow);

			var reply = client.GetRow (new UpdateRequest { Id = ID, Production = production, DT = timeStamp });

			if (reply.WasRecieved == true) {
				Console.WriteLine ("status:" + ID);
				Console.WriteLine (production);
				Console.WriteLine (timeStamp);
			} else {
				Console.WriteLine ("Message not recieved by Server");
			}

			channel.ShutdownAsync().Wait(); ///if ShutdownAsync is not encapsulated 
			//somehow, it shuts down the server before the client can connect, must fix.
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	
		public void PrintStatus(){
			
		}
	}
}

