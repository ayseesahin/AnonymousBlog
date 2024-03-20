using System;
using AnonymousBlog.Data.UnitOfWorks;
using AnonymousBlog.Entity.DTOs.Articles;
using AnonymousBlog.Entity.Entities;
using AnonymousBlog.Service.Services.Abstractions;
using AutoMapper;

namespace AnonymousBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}

