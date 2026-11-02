using CPTMS_serverV2.Modules.Core.Logger;
using CPTMS_serverV2.Modules.Data;
using CPTMS_serverV2.Modules.Login.Interfaces;
using System.Linq;

namespace CPTMS_serverV2.Modules.Login.Services
{
    public class AuthService : IAuthService
    {
        public AppDbContext dbContext;
        public AuthService(AppDbContext context)
        {
            dbContext = context;
        }

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

            var student = dbContext.Students.FirstOrDefault(s => s.LinuxAccountId == loginRequest.Username);

            if (student != null && student.PasswordHash == loginRequest.Password)
                //dbContext.Students?.Find(loginRequest.Username)?.PasswordHash == loginRequest.Password)
            {
                Logger.Log($"Logged={loginRequest.Username}");
                result.IsSuccess = true;
                result.Username = loginRequest.Username;
                result.Roles = [Role.Student];
                result.UserId = student.ID;
                result.ErrorMessage = "You should not able to see this message, if you saw this message and can't log in, please report to us.";
                return Task.FromResult(result);
            }

            /*if(false && loginRequest.Username == "admin" && loginRequest.Password == "123456")
            {
                Logger.Log($"Logged={loginRequest.Username}");
                result.IsSuccess = true;
                result.Username = "admin";
                result.Roles = [Role.Teacher];
                result.UserId = "unset";
                result.ErrorMessage = // Unexpected Error
                    "You should not see this message, if you saw this message, please report to us.";
                return Task.FromResult(result);
            }*/

            result.ErrorMessage = "InvalidCredentials";
            return Task.FromResult(result);
        }

        public Task Logout()
        {
            return Task.CompletedTask;
        }
    }
}
