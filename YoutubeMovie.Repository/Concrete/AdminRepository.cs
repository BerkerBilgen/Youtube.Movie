using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Repositories;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private MovieContext _context;

        public AdminRepository(MovieContext context)
        {
            _context = context;
        }

        public async Task<UserDTO> Login(string username, string password)
        {
            var id = await _context.Admins.Where(u => u.Username.ToLower() == username.ToLower() && u.Password == password)
                                    .Select(u => new UserDTO 
                                    {
                                        UserId = u.Id,
                                        Username = u.Username,
                                        Email = u.Email,
                                        Password = u.Password
                                    })
                                    .FirstOrDefaultAsync();

            return id;
        }
    }
}
