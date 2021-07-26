using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.Repository;

namespace YoutubeMovie.API.Controllers
{
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [EnableCors("LocalPolicy")]
    public class VideoController
    {
        private IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<List<VideoDTO>> Get()
        {
            return await _videoService.GetVideoList();
        }

        [HttpGet("{id}/detail")]
        public async Task<VideoDTO> GetVideoDetail(Guid videoId)
        {
            var videos = await _videoService.GetVideoDetail(videoId);

            return videos;
        }

        [HttpGet("category/{categoryId}")]
        [AllowAnonymous]
        public async Task<List<VideoDTO>> GetByCategory(Guid categoryId) 
        {
            return await _videoService.GetVideoByCategory(categoryId);
        }

        [HttpGet("url/{url}/detail")]
        [AllowAnonymous]
        public async Task<VideoDTO> GetByUrl(string url)
        {
            return await _videoService.GetVideoByUrl(url);
        }

        [HttpGet("search/{title}")]
        [AllowAnonymous]
        public async Task<List<VideoDTO>> SearchVideo(string title) 
        {
            return await _videoService.SearchVideo(title);
        }
    }
}
