using System;

namespace YoutubeMovie.Entities.Models
{
    public class VideoCategory : DbBaseEntity
    {
        public Guid VideoId { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Video Video { get; set; }
        public virtual Category Category { get; set; }
    }
}
