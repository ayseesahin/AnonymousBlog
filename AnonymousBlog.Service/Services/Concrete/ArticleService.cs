using System;
using AnonymousBlog.Data.UnitOfWorks;
using AnonymousBlog.Entity.Entities;
using AnonymousBlog.Service.Services.Abstractions;

namespace AnonymousBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}

