using MayFlo.API.Data;
using MayFlo.API.Models.Domain;
using MayFlo.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSSQLFlexCrud.Repositories;

namespace MayFlo.API.Controllers
{
    //https://localhost:xxxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoriesController(IRepository<Category> categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //map dto domain model
            var category = new Category
                {
                    Name = request.Name,
                    UrlHandle = request.UrlHandle
                };

            await _categoryRepository.CreateAsync(category);

            //map domain model to dto
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);
        }
    }
}
