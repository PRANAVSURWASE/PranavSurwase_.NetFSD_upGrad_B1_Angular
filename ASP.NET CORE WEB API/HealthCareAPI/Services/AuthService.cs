using HealthCareAPI.Database;
using HealthCareAPI.DTOs;

namespace HealthCareAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _token;
        public AuthService(AppDbContext context, ITokenService token)
        {
            _context = context;
            _token = token;
        }

        public string Login(LoginDto login)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);

            if (user == null)
                return null;

            return _token.GenerateToken(user);
        }
    }
}
