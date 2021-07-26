using System;

namespace YoutubeMovie.Framework.Common.Models
{
    public class AdminModel
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short Status { get; set; }
    }
}
