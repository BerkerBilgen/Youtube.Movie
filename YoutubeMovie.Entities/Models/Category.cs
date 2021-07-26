using System.Collections.Generic;

namespace YoutubeMovie.Entities.Models
{
    public class Category : DbBaseEntity
    {
        public string Name { get; set; }
        public int ColumnCount { get; set; }
        public int SortOrder { get; set; }
        public bool ShowMainPage { get; set; }
        public bool ShowCategoryMenu { get; set; }
        public string ExtraClass { get; set; }
        public virtual List<Video> Videos { get; set; }
    }
}
