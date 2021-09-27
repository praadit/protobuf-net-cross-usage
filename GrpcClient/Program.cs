
using System.Threading.Tasks;
using Grpc.Net.Client;
using System;
using Grpc.Core;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using BenchmarkDotNet.Attributes;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {   
            // BenchmarkClass program = new BenchmarkClass();
            // await program.LoginPrimitiveCall(channel);
            // var timer = new Stopwatch();

            // timer.Start();
            // await program.HttpCall();            
            // timer.Stop();
            // Console.WriteLine("Http Call : " + timer.ElapsedMilliseconds);
            
            // timer.Reset();

            // timer.Start();
            // await program.GrcpCall();
            // timer.Stop();
            // Console.WriteLine("Grpc Call : " + timer.ElapsedMilliseconds);

            // BenchmarkRunner.Run<BenchmarkLogin>();

            // BenchmarkMatchResult match = new BenchmarkMatchResult();
            // await match.GrcpCall();
        }    
    

        // public async Task LoginPrimitiveCall(GrpcChannel channel){
        //     var client = new LoginService.LoginServiceClient(channel);
        //     var reply = await client.LoginAsync(new LoginRequest { Token = "asjhdaudwkuahsd" });

        //     Console.WriteLine("Game token " + reply.LoginData.GameToken);
        //     Console.WriteLine("Press any key to exit...");
        //     Console.ReadKey();
        // }
    }
}
