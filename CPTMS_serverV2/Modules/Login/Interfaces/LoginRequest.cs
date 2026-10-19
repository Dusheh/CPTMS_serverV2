namespace CPTMS_serverV2.Modules.Login.Interfaces
{
    public class LoginRequest(string username, string password)
    {
        public string Username { get; } = username;
        public string Password { get; } = password;
    }
    
}
