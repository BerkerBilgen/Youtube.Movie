using System;
using System.Threading.Tasks;

namespace YoutubeMovie.ApplicationService
{
    public interface IAdminService
    {
        Task<Guid> Login(string username, string password);
    }
}
