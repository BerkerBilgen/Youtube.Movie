using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace YoutubeMovie.Entities.Models
{
    public class Comment: DbBaseEntity
    {
        public string Text { get; set; }
        public User User { get; set; }
        public short Status { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
