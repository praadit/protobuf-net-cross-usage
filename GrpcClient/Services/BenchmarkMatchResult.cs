using System.Threading.Tasks;
using Grpc.Net.Client;
using System;
using Grpc.Core;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using BenchmarkDotNet.Attributes;

namespace GrpcClient.Services
{
    [SimpleJob(targetCount: 5)]
    [MemoryDiagnoser]
    public class BenchmarkMatchResult{

        [Benchmark]
        public void GrcpCall(){
            // var channel = GrpcChannel.ForAddress("http://localhost:5006");
            // var client = new MatchControllerGrpcService.MatchControllerGrpcServiceClient(channel);
            // try
            // {             
            //     var headers = new Metadata();
            //     headers.Add("request-token", Guid.NewGuid().ToString());
            //     headers.Add("game-token", "0019898b-9a7d-4045-9bf0-f7684164eb84");

            //     var reply = await client.GetMatchResultAsync(
            //         new MatchResultRequest { 
            //             MatchID = "C01M001"
            //         },
            //         headers
            //     );
            //     Console.WriteLine(reply);
            // }
            // catch (RpcException ex)
            // {
            //     Console.WriteLine(ex.Status.Detail);
            // }
        }

        [Benchmark]
        public void HttpCall(){
            // HttpClient client = new HttpClient();

            // HttpRequestMessage httpRequest = new HttpRequestMessage
            // {
            //     RequestUri = new Uri("http://localhost:5007/auth/login?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJuYW1lIjoiYWRpdHlhdGVnYXIiLCJhdmF0YXIiOiJodHRwczovL3N0YXRpYy13ZWItaW50LXZpZGlvLmFrYW1haXplZC5uZXQvYXNzZXRzL2RlZmF1bHQvdXNlcl9vcmlnaW5hbC0zMDI4MmY3NTEwZjZiMTU5ZmYyOGMyMzY2OWVkZGFlM2ZkNjg4MmM2YmY4ODQwMjZkMDNhZWMyNWM4NTVhMTFmLnBuZyIsImlkIjoiQUdBVEUwMDAwMDIiLCJoYXNfdmVyaWZpZWRfcGhvbmUiOnRydWV9.UbbE_dwBVD3MPbyC45qZq6X1R8iqZHeNL8w3r6iwKh_98AUM8F8HtkqecOhWWvy8QFe8srlsSKMJh3qFl0rDlg"),
            //     Method = HttpMethod.Get,
            //     Headers = {
            //         { HttpRequestHeader.ContentType.ToString(), "application/json" },
            //         { HttpRequestHeader.Accept.ToString(), "*/*" },
            //         { "request-token", Guid.NewGuid().ToString()}
            //     }
            // };

            // HttpResponseMessage response = await client.SendAsync(httpRequest);
            
            // var actionResult = await response.Content.ReadFromJsonAsync<object>();
        }
    }
}