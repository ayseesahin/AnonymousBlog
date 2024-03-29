using System;
using AnonymousBlog.Entity.DTOs.Categories;
using AnonymousBlog.Entity.Entities;

namespace AnonymousBlog.Service.Services.Abstractions
{
	public interface ICategoryService
	{
        Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
        Task<Category> GetCategoryByGuid(Guid id);
        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<string> SafeDeleteCategoryAsync(Guid categoryId);
    }
}

