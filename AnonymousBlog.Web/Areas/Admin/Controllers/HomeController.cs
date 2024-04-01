using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnonymousBlog.Entity.Entities;
using AnonymousBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace AnonymousBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
       

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
           
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            return View(articles);
        }
       
    }

}

