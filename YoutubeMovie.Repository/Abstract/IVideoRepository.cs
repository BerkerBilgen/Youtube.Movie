using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeMovie.Repository
{
    public interface IVideoRepository
    {
        Task<Guid> Create(string name, string description, short status, string youtubeId, string imdbId);
        Task<Guid> Delete(Guid videoId);
        Task<Guid> Update(Guid videoId, string name, string description, short status, string youtubeId, string imdbId);
        Task<List<VideoDTO>> GetVideoList();
        Task<List<VideoDTO>> GetVideoByCategory(Guid categoryId);
        Task<VideoDTO> GetVideoDetail(Guid videoId);
        Task<VideoDTO> GetVideoByUrl(string url);
        Task<List<VideoDTO>> SearchVideo(string title);
    }
}
