﻿using System;
using AnonymousBlog.Entity.Entities;

namespace AnonymousBlog.Service.Services.Abstractions
{
	public interface IArticleService
	{
		Task<List<Article>> GetAllArticlesAsync();
	}
}
