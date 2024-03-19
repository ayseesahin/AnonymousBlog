using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnonymousBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


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

        public async  Task<IActionResult> Index()
        {
            var article = await articleService.GetAllArticlesAsync();
            return View(article);
        }
    }
}

