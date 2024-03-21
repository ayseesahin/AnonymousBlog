using System;
using AnonymousBlog.Entity.DTOs.Articles;
using AnonymousBlog.Entity.Entities;

namespace AnonymousBlog.Service.Services.Abstractions
{
	public interface IArticleService
	{
		Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
		Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);

        Task CreateArticleAsync(ArticleAddDto articleAddDto);
		Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

    }
}

