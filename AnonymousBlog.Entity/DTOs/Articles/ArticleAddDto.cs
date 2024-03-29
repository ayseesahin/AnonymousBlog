﻿using System;
using AnonymousBlog.Entity.DTOs.Categories;
using AnonymousBlog.Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace AnonymousBlog.Entity.DTOs.Articles
{
	public class ArticleAddDto
	{
		public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public IFormFile Photo { get; set; }

        public IList<CategoryDto> Categories { get; set; }
    }
}

