using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.Repository;

namespace YoutubeMovie.ApplicationService
{
    public interface IVideoService
    {
        Task<Guid> Create(string name, string description, short status, string youtubeId, string imdbId);
        Task<Guid> Delete(Guid videoId);
        Task<Guid> Update(Guid videoId, string name, string description, short status, string youtubeId, string imdbId);
        Task<List<VideoDTO>> GetVideoList();
        Task<List<VideoDTO>> GetVideoByCategory(Guid categoryId);
        Task<VideoDTO> GetVideoDetail(Guid id);
        Task<VideoDTO> GetVideoByUrl(string url);
        Task<List<VideoDTO>> SearchVideo(string title);
    }
}
