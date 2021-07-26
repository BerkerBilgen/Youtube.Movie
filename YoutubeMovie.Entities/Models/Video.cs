using System.Collections.Generic;

namespace YoutubeMovie.Entities.Models
{
    public class Video : DbBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Banner { get; set; }
        public string BannerLowQuality { get; set; }
        public string Poster { get; set; }
        public string PosterLowQuality { get; set; }
        public string AlternativePoster { get; set; }
        public string AlternativePosterLowQuality { get; set; }
        public short Status { get; set; }
        public string YoutubeId { get; set; }
        public string ImbdId { get; set; }
        public string Url { get; set; }
        public virtual List<VideoCategory> Categories { get; set; }
    }
}
