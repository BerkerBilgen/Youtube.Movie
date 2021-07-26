using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.Authentication.JWT;
using YoutubeMovie.Repositories;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.ApplicationService
{
    public class UserService : IUserService
    {
        private IAuthenticationRepository _authenticationRepository;
        private IUserRepository _userRepository;

        public UserService(IAuthenticationRepository authenticationRepository, IUserRepository userRepository) 
        {
            _authenticationRepository = authenticationRepository;
            _userRepository = userRepository;
        }

        public async Task<Guid> Register(CreateUser request) 
        {
            return await _userRepository.Create(request.Username, request.Email, request.Password, request.Status);
        }

        public async Task<Guid> Create(string username, string email, string password, short status)
        {
            return await _userRepository.Create(username, email, password, status);
        }

        public async Task<Guid> Delete(Guid userId)
        {
            return await _userRepository.Delete(userId);
        }

        public async Task<Guid> Update(Guid userId, string email, string password, short status)
        {
            return await _userRepository.Update(userId, email, password, status);
        }

        public async Task<List<UserDTO>> GetUserList()
        {
            return await _userRepository.GetUserList();
        }

        public async Task<UserDTO> GetUserById(Guid userId, string email, string password, short status)
        {
            return await _userRepository.GetUserById(userId, email, password, status);
        }

        public async Task<string> Login(string username, string password)
        {
            var userId = await _userRepository.Login(username, password);

            if (userId == Guid.Empty)
                throw new Exception("Kullanıcı adı veya şifre hatalı!");

            return _authenticationRepository.CreateToken(username, password);
        }
    }
}
