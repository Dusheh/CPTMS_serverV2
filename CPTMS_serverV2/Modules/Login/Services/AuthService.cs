using CPTMS_serverV2.Modules.Core.Logger;
using CPTMS_serverV2.Modules.Login.Interfaces;

namespace CPTMS_serverV2.Modules.Login.Services
{
    public class AuthService : IAuthService
    {
        public Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var result = new LoginResponse
            {
                IsSuccess = false
            };
            if (string.IsNullOrWhiteSpace(loginRequest.Username))
            {
                var errorMsg = "Username is null";
                result.ErrorMessage = errorMsg;
                Logger.Log(errorMsg);
                return Task.FromResult(result);
            }
            if (string.IsNullOrWhiteSpace(loginRequest.Password))
            {
                var errorMsg = "Password is null";
                result.ErrorMessage = errorMsg;
                Logger.Log(errorMsg);
                return Task.FromResult(result);
            }

            if(loginRequest.Username == "admin" && loginRequest.Password == "123456")
            {
                Logger.Log($"Logged={loginRequest.Username}");
                result.IsSuccess = true;
                result.Username = "admin";
                result.Roles = [Role.Teacher];
                result.UserId = "unset";
                result.ErrorMessage = // Unexpected Error
                    "You should not see this message, if you saw this message, please report this.";
                return Task.FromResult(result);
            }

            result.ErrorMessage = "InvalidCredentials";
            return Task.FromResult(result);
        }

        public Task Logout()
        {
            return Task.CompletedTask;
        }
    }
}
