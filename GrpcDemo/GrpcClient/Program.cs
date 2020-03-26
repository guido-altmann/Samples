using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService;

namespace GrpcClient
{
    class Program
    {
        static async Task Main()
        {
            //Console.WriteLine("Hello World!");
           
            //AppContext.SetSwitch(
            //    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            // Create channel.
            // Represents long-lived connection to gRPC service.
            // The port number(5001) must match the port of the gRPC server.
            // Tip: In ASP.NET Core apps, use client factory (similar to
            //      IHttpClientFactory (see https://docs.microsoft.com/en-us/aspnet/core/grpc/clientfactory).
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Guido" });
            Console.WriteLine("Greeting: " + reply.Message);

            reply = await client.SayGoodbyeAsync(new HelloRequest {Name = "Guido"});
            Console.WriteLine("Greeting: " + reply.Message);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
