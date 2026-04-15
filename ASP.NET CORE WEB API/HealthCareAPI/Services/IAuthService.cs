using HealthCareAPI.DTOs;

namespace HealthCareAPI.Services
{
    public interface IAuthService
    {
        string Login(LoginDto dto);
    }
}
