using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace YoutubeMovie.Entities.Models
{
   public class Slider : DbBaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public short Status { get; set; }
    }
}
