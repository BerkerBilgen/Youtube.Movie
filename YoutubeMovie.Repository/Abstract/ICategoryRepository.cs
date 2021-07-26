using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeMovie.Repository
{
    public interface ICategoryRepository
    {
        Task<Guid> Create(string name);

        Task<Guid> Update(Guid categoryId, string name);

        Task<Guid> Delete(Guid categoryId);

        Task<List<CategoryDTO>> GetCategoryList();

        Task<List<CategoryDTO>> GetMainPageCategories();

        Task<CategoryDTO> GetCategoryById(Guid categoryId);
    }
}
