using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeMovie.ApplicationService
{
    public interface ICommentService
    {
        Task<Guid> Create(string text, short status);
    }
}
