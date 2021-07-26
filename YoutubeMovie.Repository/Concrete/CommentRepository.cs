using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Entities.Models;
using YoutubeMovie.Repository.Abstract;

namespace YoutubeMovie.Repository
{
    public class CommentRepository : ICommentRepository
    {
        MovieContext _context;

        public CommentRepository(MovieContext context)
        {
            _context = context;
        }

        public async Task<Guid> Create(string text, short status)
        {
            try
            {
                var comment = new Comment
                {
                    Id = Guid.NewGuid(),
                    Text= text,
                    Status = status
                };

                await _context.Comments.AddAsync(comment);

                await _context.SaveChangesAsync();

                return comment.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
