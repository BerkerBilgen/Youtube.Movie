using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeMovie.CMS.Models
{
    public class CreateVideoRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public short Status { get; set; }

        public string ImdbId { get; set; }

        public string YoutubeId { get; set; }
    }
}
