using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeMovie.Repository;

namespace YoutubeMovie.ApplicationService
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<Guid> Create( string name)
        {
            return await _categoryRepository.Create(name);
        }

        public async Task<Guid> Update(Guid categoryId, string name)
        {
            return await _categoryRepository.Update(categoryId, name);
        }

        public async Task<Guid> Delete(Guid categoryId)
        {
            return await _categoryRepository.Delete(categoryId);
        }

        public async Task<List<CategoryDTO>> GetCategoryList()
        {
            return await _categoryRepository.GetCategoryList();
        }

        public async Task<List<CategoryDTO>> GetMainPageCategories() 
        {
            return await _categoryRepository.GetMainPageCategories();
        }

        public async Task<CategoryDTO> GetCategoryById(Guid categoryId)
        {
            return await _categoryRepository.GetCategoryById(categoryId);
        }

    }
}
