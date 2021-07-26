using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using YoutubeMovie.API.Models;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.Framework.Common;

namespace YoutubeMovie.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController : BaseApiController
    {
        private IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<Guid> Create(CreateUserRequest request) 
        {
            return await _userService.Register(new CreateUser {
                Username = request.Username,
                Email = request.Email,
                Password = request.Password,
                Status = (short)request.Status
            });
        }

        [HttpPost("token")]
        [AllowAnonymous]
        public async Task<string> GetToken(GetTokenRequest request) 
        {
            return await _userService.Login(request.Username, request.Password);
        }
    }
}
