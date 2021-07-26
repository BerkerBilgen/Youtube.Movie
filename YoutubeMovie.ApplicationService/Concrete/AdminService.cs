using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using YoutubeMovie.Repositories;
using YoutubeMovie.Framework.Common.Extensions;

namespace YoutubeMovie.ApplicationService
{
    public class AdminService : IAdminService
    {
        private IHttpContextAccessor _accessor;
        private IAdminRepository _adminRepository;

        public AdminService(IHttpContextAccessor accessor, IAdminRepository adminRepository) 
        {
            _accessor = accessor;
            _adminRepository = adminRepository;
        }

        public async Task<Guid> Login(string username, string password)
        {
            var admin = await _adminRepository.Login(username, password);

            if (admin == null || admin.UserId == Guid.Empty)
                throw new Exception("Kullanıcı adı veya şifre hatalı!");

            _accessor.HttpContext.Session.SetObject("Admin", admin);

            return admin.UserId;
        }
    }
}
