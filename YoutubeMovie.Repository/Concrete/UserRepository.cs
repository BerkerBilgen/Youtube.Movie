using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Entities.Models;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MovieContext _context;

        public UserRepository(MovieContext context) 
        {
            _context = context;
        }

        public async Task<Guid> Create(string username, string email, string password, short status)
        {
            try
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Username = username,
                    Email = email,
                    Password = password,
                    Status = status
                };

                await _context.Users.AddAsync(user);

                await _context.SaveChangesAsync();

                return user.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Guid> Delete(Guid userId)
        {
            try
            {
                var user = new User
                {
                    Id = userId,
                    Status = 2
                };
                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return user.Id;
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public async Task<Guid> Update(Guid userId, string email, string password, short status)
        {
            try
            {
                var user = new User
                {
                    Id = userId,
                    Email = email,
                    Password = password,
                    Status = status
                };

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return user.Id;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<List<UserDTO>> GetUserList()
        {
            try
            {
                return await _context.Users.Select(u => new UserDTO
                {
                    UserId = u.Id,
                    Email = u.Email,
                    Password = u.Password,
                    Status = u.Status,
                    Username = u.Username
                }).ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<UserDTO> GetUserById(Guid userId, string email, string password, short status)
        {
            try
            {
                var user = await _context.Users.Select(v => new UserDTO()
                {
                 UserId = v.Id,
                 Email = v.Email,
                 Password = v.Password,
                 Username = v.Username,
                 Status = v.Status
                }).SingleOrDefaultAsync(v => v.UserId == userId);

                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<Guid> Login(string username, string password) 
        {
            var id = await _context.Users.Where(u => u.Username.ToLower() == username.ToLower() && u.Password == password).Select(u => u.Id).FirstOrDefaultAsync();

            return id;
        }
    }
}
