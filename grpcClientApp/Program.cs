using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Threading.Tasks;

namespace grpcClientApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Details = "Stuart Mukasa", Age="90" };
            var channel = GrpcChannel.ForAddress("http://localhost:5187");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(input);
            Console.WriteLine(reply.Message);
            Console.ReadLine();
        }
    }
}
