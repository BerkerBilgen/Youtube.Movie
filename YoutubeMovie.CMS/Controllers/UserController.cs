using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.CMS.Models;
using YoutubeMovie.Repositories.DTO;

namespace YoutubeMovie.CMS.Controllers
{
    public class UserController : Controller
    {
        UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            await _userService.Create(request.Username, request.Email, request.Password, request.Status);

            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteUserRequest request)
        {
            await _userService.Delete(request.UserId);

            return View();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserRequest request)
        {

            await _userService.Update(request.UserId, request.Email, request.Password, request.Status);

            return View();
        }

        [HttpGet]

        public async Task<IActionResult> GetUserList()
        {
            await _userService.GetUserList();

            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUserById(GetUserRequest request)
        //{
        //    await _userService.GetUserById(request.UserId, request.Email, request.Password, request.Status);

        //    return View();
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}
