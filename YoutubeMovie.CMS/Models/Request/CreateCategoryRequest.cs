using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeMovie.CMS.Models
{
    public class CreateCategoryRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
