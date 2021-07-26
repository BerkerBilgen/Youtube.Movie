using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeMovie.ApplicationService;
using YoutubeMovie.CMS.Models;

namespace YoutubeMovie.CMS.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryRequest request)
        {
            await _categoryService.Create(request.Name);

            return View();
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(DeleteCategoryRequest request)
        {
            await _categoryService.Delete(request.CategoryId);

            return View();
        }

        [HttpPut]

        public async Task<IActionResult> Update(UpdateCategoryRequest request)
        {
            await _categoryService.Update(request.CategoryId, request.Name);

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            await _categoryService.GetCategoryList();

            return View();
        }

        [HttpGet]

        public async Task<IActionResult> GetCategoryById(GetCategoryRequest request) {
            await _categoryService.GetCategoryById(request.CategoryId);
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
