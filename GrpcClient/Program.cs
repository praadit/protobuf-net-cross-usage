using BenchmarkDotNet.Engines;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Net;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Program program = new Program();
            // await program.LoginPrimitiveCall();

            // await program.LoginHttpCall();
            var summary = BenchmarkRunner.Run<Benchy>();
        }    
    }
    [SimpleJob(RunStrategy.Throughput, targetCount: 50)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn, MemoryDiagnoser]
    public class Benchy{

        [Benchmark]
        public async Task LoginPrimitiveCall(){
            GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7001");

            var client = new LoginService.LoginServiceClient(channel);
            var reply = await client.LoginAsync(new LoginRequest { Token = "asjhdaudwkuahsd" });
            string replyString = JsonSerializer.Serialize(reply);
            // Console.WriteLine("Game token " + replyString);
            // Console.WriteLine("Press any key to exit...");
            // Console.ReadKey();
        }

        [Benchmark]
        public async Task LoginHttpCall(){
            HttpClient client = new HttpClient();
            LoginRequest request = new LoginRequest{Token = "asjhdaudwkuahsd"};
            HttpRequestMessage httpRequest = new HttpRequestMessage
            {
                RequestUri = new Uri("http://localhost:7002/api/login"),
                Method = HttpMethod.Post,
                Headers = {
                    { HttpRequestHeader.ContentType.ToString(), "application/json" },
                    { HttpRequestHeader.Accept.ToString(), "*/*" },
                    { "request-token", Guid.NewGuid().ToString()}
                },                
                Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json")
            };

            HttpResponseMessage response = await client.SendAsync(httpRequest);
            // Console.WriteLine(response.StatusCode);
            if(response.Content != null){
                var actionResult = await response.Content.ReadFromJsonAsync<LoginResponse>();
                // Console.WriteLine("Game token " + actionResult);
                // Console.WriteLine("Press any key to exit...");
                // Console.ReadKey();
            }
        }
    }
}
