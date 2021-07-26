using System;
using System.Threading.Tasks;

namespace YoutubeMovie.Repository.Abstract
{
    public interface ICommentRepository
    {
        Task<Guid> Create(string text, short status);
    }
}
