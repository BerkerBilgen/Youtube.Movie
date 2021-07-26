using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.Repository;

namespace YoutubeMovie.ApplicationService
{
    public class VideoService : IVideoService
    {
        private IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public async Task<Guid> Create(string name, string description, short status, string youtubeId, string imdbId)
        {
            return await _videoRepository.Create(name, description, status, youtubeId, imdbId);
        }

        public async Task<Guid> Delete(Guid videoId)
        {
            return await _videoRepository.Delete(videoId);
        }

        public async Task<Guid> Update(Guid videoId, string name, string description, short status, string youtubeId, string imdbId)
        {
            return await _videoRepository.Update(videoId, name, description, status, youtubeId, imdbId);
        }

        public async Task<List<VideoDTO>> GetVideoList()
        {
            return await _videoRepository.GetVideoList();
        }

        public async Task<List<VideoDTO>> GetVideoByCategory(Guid categoryId)
        {
            return await _videoRepository.GetVideoByCategory(categoryId);
        }

        public async Task<VideoDTO> GetVideoDetail(Guid id) 
        {
            return await _videoRepository.GetVideoDetail(id);
        }

        public async Task<VideoDTO> GetVideoByUrl(string url) 
        {
            return await _videoRepository.GetVideoByUrl(url);
        }

        public async Task<List<VideoDTO>> SearchVideo(string title) 
        {
            return await _videoRepository.SearchVideo(title);
        }
    }
}
