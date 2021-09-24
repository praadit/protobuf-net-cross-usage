using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Grpc.Reflection;
using GrpcServer.Models.Protos;

namespace GrpcServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var schema = new Program().GenerateProtoFile<ILoginService>();
            Console.WriteLine(schema);
            
            CreateHostBuilder(args).Build().Run();

        }        

        public string GenerateProtoFile<T>() where T : class{
            var generator = new SchemaGenerator(); // optional controls on here, we can add more add needed
            var schema = generator.GetSchema<T>(); 
            return schema;
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
