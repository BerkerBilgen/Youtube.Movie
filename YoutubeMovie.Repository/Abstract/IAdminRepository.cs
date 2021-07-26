using System.Threading.Tasks;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.Repositories
{
    public interface IAdminRepository
    {
        Task<UserDTO> Login(string username, string password);
    }
}
