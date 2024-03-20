using System;
using AnonymousBlog.Entity.DTOs.Categories;

namespace AnonymousBlog.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
	}
}

