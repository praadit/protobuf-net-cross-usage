namespace HttpServer
{
    public class LoginRequest
    {    
        public string Token { get; set; }
    }
    public class LoginResponse{
        public LoginData LoginData { get; set; }
        public long Timestamps { get; set; }
    }

    public class LoginData{
        public string GameToken { get; set; }
    }
}