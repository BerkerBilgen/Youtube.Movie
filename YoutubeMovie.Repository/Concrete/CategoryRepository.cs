using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Entities.Data;
using YoutubeMovie.Entities.Models;

namespace YoutubeMovie.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        MovieContext _context;

        public CategoryRepository(MovieContext context)
        {
            _context = context;
        }
        public async Task<Guid> Create(string name)
        {
            try
            {
                var category = new Category
                {
                    Id = new Guid(),
                    Name = name
                };

                await _context.Categories.AddAsync(category);

                await _context.SaveChangesAsync();

                return category.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Guid> Update(Guid categoryId, string name)
        {
            try
            {
                var category = new Category
                {
                    Id = categoryId,
                    Name = name
                };

                _context.Categories.Update(category);

                await _context.SaveChangesAsync();

                return category.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Guid> Delete(Guid categoryId)
        {
            try
            {
                var category = new Category
                {
                    Id = categoryId
                };

                _context.Categories.Remove(category);

                await _context.SaveChangesAsync();

                return category.Id;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<CategoryDTO>> GetCategoryList()
        {
            try
            {
                return await _context.Categories.Select(c => new CategoryDTO
                {
                    CategoryId = c.Id,
                    Name = c.Name
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<CategoryDTO>> GetMainPageCategories()
        {
            try
            {
                return await _context.Categories.Where(c => c.ShowMainPage).Select(c => new CategoryDTO
                {
                    CategoryId = c.Id,
                    Name = c.Name,
                    ColumnCount = c.ColumnCount,
                    ExtraClass = c.ExtraClass,
                    SortOrder = c.SortOrder
                }).OrderBy(c => c.SortOrder).ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<CategoryDTO> GetCategoryById(Guid categoryId)
        {
            try
            {
                var video = await _context.Categories.Select(c => new CategoryDTO()
                {
                    CategoryId = c.Id,
                    Name = c.Name
                }).SingleOrDefaultAsync(c => c.CategoryId == categoryId);

                return video;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
