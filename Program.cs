// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using gRPCService;

Console.WriteLine("##### gRPC Client APP ######");
var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(
    new HelloRequest { Name = " World" });

Console.WriteLine(response.Message);

var responsebye = await client.sayByeAsync(
    new HelloRequest { Name = " World" });

Console.WriteLine(responsebye.Byemessage);

Console.ReadKey();
