using System;
using AnonymousBlog.Entity.DTOs.Articles;
using AnonymousBlog.Entity.Entities;
using AutoMapper;

namespace AnonymousBlog.Service.AutoMapper.Articles
{
	public class ArticleProfile : Profile
	{
		public ArticleProfile()
		{
			CreateMap<ArticleDto, Article>().ReverseMap();
		}
	}
}

