using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YoutubeMovie.Entities.Models
{
    public abstract class DbBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreateUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
