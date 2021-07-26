using System;

namespace YoutubeMovie.Repository
{
    public class CategoryDTO
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string ExtraClass { get; set; }
        public int ColumnCount { get; set; }
        public int SortOrder { get; set; }
    }
}
