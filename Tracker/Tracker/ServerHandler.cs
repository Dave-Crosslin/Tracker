using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrackerRPC;


namespace Tracker
{
	class TrackerRPCImpl : dbUpdate.dbUpdateBase

	{
		public override Task<RecieptConfirmation> GetRow( UpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult(new RecieptConfirmation { WasRecieved = true});
		}
	}
	public class ServerHandler
	{
		public ServerHandler ()
		{
			
		}

		const int Port = 50051;

		public void StartServer(){		
			Server server = new Server {
				Services = { dbUpdate.BindService (new TrackerRPCImpl ()) },
				Ports = { new ServerPort ("localhost", Port, ServerCredentials.Insecure) }
			};
			server.Start ();
			Console.WriteLine ("Tracker Server listening on port " + Port);
			Console.WriteLine ("Press any key to stop the server...");
			Console.ReadKey ();
			
			string stopCommand = "wait";
			if (stopCommand == null) {
				server.ShutdownAsync ().Wait ();
			}
		}
	}
}

