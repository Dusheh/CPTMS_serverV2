namespace CPTMS_serverV2.Modules.Login.Interfaces
{
    /*public enum LoginResult
    {
        Success,
        InvalidCredentials, //用户名或密码错误
        ServerError
    }*/
    public class LoginResponse
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public string? UserId { get; set; } // Uncompleted UserId
        public string? Username { get; set; }
        public List<Role> Roles { get; set; } = [];
    }
}
