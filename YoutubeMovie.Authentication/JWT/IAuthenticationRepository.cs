using System.Threading.Tasks;

namespace YoutubeMovie.Authentication.JWT
{
    public interface IAuthenticationRepository
    {
        string CreateToken(string username, string passsword);
        Task<bool> Validate(string token);
    }
}
