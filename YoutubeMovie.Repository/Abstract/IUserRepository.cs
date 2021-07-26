using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> Create(string username, string email, string password, short status);

        Task<Guid> Delete(Guid userId);

        Task<Guid> Update(Guid userId, string email, string password, short status);

        Task<List<UserDTO>> GetUserList();

        Task<UserDTO> GetUserById(Guid userId, string email, string password, short status);
        Task<Guid> Login(string username, string password);
    }
}
