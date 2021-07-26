using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.Repository;

namespace YoutubeMovie.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("LocalPolicy")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<List<CategoryDTO>> Get()
        {
            return await _categoryService.GetCategoryList();
        }

        [HttpGet("mainpage")]
        [AllowAnonymous]
        public async Task<List<CategoryDTO>> GetMainPageCategories() 
        {
            return await _categoryService.GetMainPageCategories();
        }
    }
}
