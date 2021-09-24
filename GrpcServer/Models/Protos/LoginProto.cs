using System.ServiceModel;
using System.Threading.Tasks;
using ProtoBuf;
using ProtoBuf.Grpc;

namespace GrpcServer.Models.Protos
{
    [ProtoContract]
    public class LoginRequest
    {
        [ProtoMember(1)]        
        public string Token { get; set; }
    }

    [ProtoContract]
    public class LoginResponse
    {
        [ProtoMember(1)]
        public LoginData LoginData { get; set; }
        [ProtoMember(2)]   
        public long Timestamps { get; set; }
    }

    [ProtoContract]
    public class LoginData{
        [ProtoMember(1)]
        public string GameToken { get; set; }
    }

    [ServiceContract]
    public interface ILoginService
    {   
        Task<LoginResponse> Login(LoginRequest request, CallContext context = default);
    }
}