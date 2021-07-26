using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.CMS.Models;
using YoutubeMovie.CMS.Models.ViewModel;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Repository;
using System.Linq;
using YoutubeMovie.Framework.Common.Attributes;

namespace YoutubeMovie.CMS.Controllers
{
    [ServiceFilter(typeof(AthenticationActionFilter))]
    public class VideoController : Controller
    {
        private IVideoService _videoService;

        private MovieContext _movieContext;

        public VideoController(IVideoService videoService, MovieContext movieContext)
        {
            _videoService = videoService;
            _movieContext = movieContext;
        }


        public IActionResult CreateVideo()
        {
            var viewModel = new Video();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVideoRequest request) 
        {
            await _videoService.Create(request.Name, request.Description, request.Status, request.YoutubeId, request.ImdbId);

            return CreateVideo();
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(DeleteVideoRequest request)
        {
            await _videoService.Delete(request.VideoId);

                return View();
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateVideoRequest request)
        {
            await _videoService.Update(request.VideoId, request.Name, request.Description, request.Status, request.YoutubeId, request.ImdbId);

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetVideoList()
        {
            var videos = _videoService.GetVideoList().Result.Select(v => new Video
            {
                Name = v.Name,
                ImdbId = v.ImdbId,
                Description = v.Description,
                Status = v.Status,
                YoutubeId = v.YoutubeId

            }).ToList();

            return View(videos);
        }

        [HttpGet("{id}/detail")]
        public async Task<VideoDTO> GetVideoDetail(string videoId) 
        {
            var videos = await _videoService.GetVideoDetail(new System.Guid(videoId));

            return videos;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetVideoById(GetVideoRequest request)
        //{
        //    await _videoService.GetVideoById(request.VideoId);

        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
