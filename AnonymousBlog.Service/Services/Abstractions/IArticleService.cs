using System;
using AnonymousBlog.Entity.DTOs.Articles;
using AnonymousBlog.Entity.Entities;

namespace AnonymousBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();

        Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync();

        Task CreateArticleAsync(ArticleAddDto articleAddDto);

        Task<ArticleDto> GetAllArticlesWithCategoryNonDeletedAsync(Guid articleId);

        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

        Task<string> SafeDeleteArticleAsync(Guid articleId);

        Task<string> UndoDeleteArticleAsync(Guid articleId);

    }
}

