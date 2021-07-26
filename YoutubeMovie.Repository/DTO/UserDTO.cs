using System;

namespace YoutubeMovie.Repositories.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short Status { get; set; }
    }
}
