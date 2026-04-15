using HealthCareAPI.Models;


namespace HealthCareAPI.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
