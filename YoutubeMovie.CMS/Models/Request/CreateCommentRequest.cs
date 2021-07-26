using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeMovie.CMS.Models
{
    public class CreateCommentRequest
    {
        public string Text { get; set; }
        public short Status { get; set; }
    }
}
