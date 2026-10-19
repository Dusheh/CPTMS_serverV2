namespace CPTMS_serverV2.Modules.Login.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        public Task Logout();
    }
}
