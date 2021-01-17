using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VIPStore.Models;
using VIPStore.Models.ViewModels;

namespace VIPStore.Controllers
{
    public class HomeController : Controller
    {
        
        private IStoreRepository repository;
        public int PageSize = 8;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Products);

        public ViewResult Index(string category , int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    IteamsPerPage = PageSize,
                    TotalIteams = repository.Products.Count()
                }
            });

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }

                     
        //localhost:5000/?productPage=2
}
