using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeMovie.ApplicationService
{
    public class CreateUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short Status { get; set; }
    }
}
