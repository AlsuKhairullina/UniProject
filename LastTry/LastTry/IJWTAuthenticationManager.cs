using LastTry.Models;

namespace LastTry
{
    public interface IJWTAuthenticationManager
    {
        public string Authenticate(User model);
    }
}