using System;
using AnonymousBlog.Entity.DTOs.Categories;
using AnonymousBlog.Entity.Entities;
using AutoMapper;

namespace AnonymousBlog.Service.AutoMapper.Categories
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CategoryAddDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();

        }
    }
}

