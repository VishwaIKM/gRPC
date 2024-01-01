// See https://aka.ms/new-console-template for more information

using Client;
using Grpc.Net.Client;
using System.Runtime.CompilerServices;

Console.WriteLine("Press any Key to start .... ");

Console.ReadKey();

Console.WriteLine("==============================================================================================");
Console.WriteLine("==============================================================================================");
Console.WriteLine("======================================  [ Contract Data ]   ==================================");
Console.WriteLine("==============================================================================================");
Console.WriteLine("==============================================================================================");


using var channel = GrpcChannel.ForAddress("https://localhost:7130");
var clients = new Greeter.GreeterClient(channel);
var reply =await clients.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine($"RESP: {reply.Message} ");
Console.WriteLine("==============================");
var cc = new ContractDetails.ContractDetailsClient(channel);
var rep = await cc.GetContractInfoAsync(new ContractLookUpModel { Tokens = 111 });
Console.WriteLine($"RESP: {rep.TradingSymbol} ");
Console.WriteLine("=============[END]==============");
Console.ReadLine();
