using System;
using System.Threading.Tasks;
using Grpc.Core;
using TrackerRPC;

namespace TrackerServer
{
	class TrackerRPCImpl : dbUpdate.dbUpdateBase

	{
		// Server side handler of the dbUpdate RPC
		public override Task<RecieptConfirmation> GetRow( UpdateRequest request, ServerCallContext context)
		{
			return Task.FromResult(new RecieptConfirmation { WasRecieved = true});

		}
	}

	class MainClass
	{
		const int Port = 50051;
		
		public static void Main (string[] args)
		{
			Server server = new Server
			{
				Services = {dbUpdate.BindService(new TrackerRPCImpl()) },
				Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
			};
			server.Start();

			Console.WriteLine ("Tracker Server listening on port " + Port);
			Console.WriteLine("Press any key to stop the server...");

		
			Console.ReadKey();
			
			server.ShutdownAsync().Wait();


		}
			
	}
}
