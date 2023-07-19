using POM_trial.Models;
using POM_trial.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using POM_trial.Migrations;

namespace POM_trial.Controllers
{
    [Authorize(Roles ="User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string sterm = "", int categoryId = 0)
        {
            IEnumerable<Product> Products = await _homeRepository.GetProducts(sterm, categoryId);
            IEnumerable<Category> Categories = await _homeRepository.Categories();
            ProductDisplayModel ProductsModel = new ProductDisplayModel
            {
                Products = Products,
                Categories = Categories,
                STerm = sterm,
                CategoryId = categoryId
            };
            return View(ProductsModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}