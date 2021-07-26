using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.CMS.Models;

namespace YoutubeMovie.CMS.Controllers
{
    public class CommentController : Controller
    {
        CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
       public async Task<IActionResult> Create(CreateCommentRequest request)
        {
            //string text, short status
            await _commentService.Create(request.Text, request.Status);

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
