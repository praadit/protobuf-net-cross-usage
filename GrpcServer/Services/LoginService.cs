using GrpcServer.Models.Protos;
using ProtoBuf.Grpc;
using System.Threading.Tasks;
using System;

namespace GrpcServer.Services
{
    
    public class LoginService : ILoginService
    {
        public Task<LoginResponse> Login(LoginRequest request, CallContext context = default){
            return Task.FromResult(new LoginResponse() {
                LoginData = new LoginData{
                    GameToken = Guid.NewGuid().ToString()
                },
                Timestamps = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()
            });
        }
    }
}