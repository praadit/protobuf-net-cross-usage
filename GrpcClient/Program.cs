using System.Threading.Tasks;
using Grpc.Net.Client;
using System;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {   
            Program program = new Program();

            var channel = GrpcChannel.ForAddress("https://localhost:7001");
            await program.LoginPrimitiveCall(channel);
        }

        public async Task LoginPrimitiveCall(GrpcChannel channel){
            var client = new LoginService.LoginServiceClient(channel);
            var reply = await client.LoginAsync(new LoginRequest { Token = "asjhdaudwkuahsd" });

            Console.WriteLine("Game token " + reply.LoginData.GameToken);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
