using FlowerShop.Dto;
using FlowerShop.EF;
using FlowerShop.EF.Models;
using FlowerShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var categories = await _dbContext.Categories.ToListAsync();
            return View(new ShopViewModel { Categories = categories });
        }

        [Route("/product/{tag}")]
        public async Task<IActionResult> Product(string tag)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Tag == tag);
            return View(new ProductViewModel { Product = product });
        }

        [Route("/cart")]
        public IActionResult Cart()
        {
            return View(new CartViewModel()
            {
                PreviousUrl = Request.Headers["Referer"].ToString()
            });
        }

        [Route("/post-cart")]
        [HttpPost]
        public IActionResult PostCart(OrderDto dto)
        {
            return Ok(dto);
        }

        [Route("/search")]
        public IActionResult Search(string q)
        {
            return View(new SearchViewModel { Query = q });
        }

        [Route("/error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
