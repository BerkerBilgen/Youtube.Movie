using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Entities.Models;

namespace YoutubeMovie.Repository
{
    public class VideoRepository : IVideoRepository
    {
        private MovieContext _context;

        public VideoRepository(MovieContext context)
        {
            _context = context;
        }
        public async Task<Guid> Create(string name, string description, short status,string youtubeId, string imdbId)
        {
            try
            {
                var video = new Video
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Description = description,
                    Status = 1,
                    YoutubeId = youtubeId,
                    ImbdId = imdbId
                };

                await _context.Videos.AddAsync(video);

                await _context.SaveChangesAsync();

                return video.Id;
            }

            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<Guid> Delete(Guid videoId)
        {
            try
            {
                var video = new Video
                {
                    Id = videoId
                };

                _context.Videos.Remove(video);

                await _context.SaveChangesAsync();

                return video.Id;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<Guid> Update(Guid videoId, string name, string description, short status, string youtubeId, string imdbId)
        {
            try
            {
                var video = new Video
                {
                    Id = videoId,
                    Name = name,
                    Description = description,
                    YoutubeId = youtubeId,
                    ImbdId = imdbId
                };

                _context.Videos.Update(video);

                await _context.SaveChangesAsync();

                return video.Id;
            }

            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<List<VideoDTO>> GetVideoList()
        {
            try
            {
                return await _context.Videos.Where(v => v.Status == 1).Select(v => new VideoDTO
                {
                    Id = v.Id,
                    Name = v.Name,
                    Description = v.Description,
                    Status = v.Status,
                    YoutubeId = v.YoutubeId,
                    ImdbId = v.ImbdId,
                    Banner = v.Banner,
                    Poster = v.Poster,
                    AlternativePoster = v.AlternativePoster
                }).ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<VideoDTO> GetVideoById(Guid userId)
        {
            try
            {
                var video = await _context.Videos.Select(v => new VideoDTO() {
                    Id = v.Id,
                    Name = v.Name,
                    Description = v.Description,
                    Status = v.Status,
                    ImdbId = v.ImbdId,
                    YoutubeId = v.YoutubeId
                }).SingleOrDefaultAsync(v => v.Id == userId);

                return video;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<List<VideoDTO>> GetVideoByCategory(Guid categoryId)
        {
            try
            {
                var videos = await _context.Videos.Include(v => v.Categories)
                    .Where(v => v.Categories.Any(c => c.CategoryId == categoryId))
                    .Select(v => new VideoDTO { 
                        Id = v.Id,
                        Name = v.Name,
                        Description = v.Description,
                        ImdbId = v.ImbdId,
                        YoutubeId = v.YoutubeId,
                        Banner = v.Banner,
                        Poster = v.Poster,
                        AlternativePoster = v.AlternativePoster,
                        Url = v.Url
                    }).ToListAsync();

                return videos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<VideoDTO> GetVideoDetail(Guid videoId) 
        {
            return await _context.Videos.Where(v => v.Id == videoId)
                        .Select(v => new VideoDTO
                        {
                            Id = v.Id,
                            Description = v.Description,
                            Name = v.Name,
                            Poster = v.Poster,
                            AlternativePoster = v.AlternativePoster,
                            Banner = v.Banner
                        }).FirstOrDefaultAsync();
        }

        public async Task<VideoDTO> GetVideoByUrl(string url) 
        {
            return await _context.Videos.Where(v => v.Url == url)
                        .Select(v => new VideoDTO
                        {
                            Id = v.Id,
                            Description = v.Description,
                            Name = v.Name,
                            Poster = v.Poster,
                            AlternativePoster = v.AlternativePoster,
                            Banner = v.Banner,
                            AlternativePosterLowQuality = v.AlternativePosterLowQuality,
                            BannerLowQuality = v.BannerLowQuality,
                            PosterLowQuality = v.PosterLowQuality,
                            YoutubeId = v.YoutubeId
                        }).FirstOrDefaultAsync();
        }

        public async Task<List<VideoDTO>> SearchVideo(string title)
        {
            return await _context.Videos.Where(v => v.Name.Contains(title))
                        .Select(v => new VideoDTO
                        {
                            Id = v.Id,
                            Name = v.Name,
                            Poster = v.Poster,
                            Url = v.Url,
                            YoutubeId = v.YoutubeId
                        }).Take(3).ToListAsync();
        }
    }
}
