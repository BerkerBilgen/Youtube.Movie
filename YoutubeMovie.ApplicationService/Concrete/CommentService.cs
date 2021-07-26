using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Repository;
using YoutubeMovie.Repository.Abstract;

namespace YoutubeMovie.ApplicationService
{
   public class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<Guid> Create(string text, short status)
        {
            return await _commentRepository.Create(text, status);
        }
    }
}
