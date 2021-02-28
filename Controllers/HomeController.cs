using Assignment5.Models;
using Assignment6.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int page = 1)
        {
            return View(new ProjectListViewModel
            {
                // this creates the list of books that are to be loaded on the page
                Projects = _repository.Projects
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.BookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                //this does the page render stuff
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Projects.Count() :
                            _repository.Projects.Where(x => x.Category == category).Count()
                },
                Type = category
            });
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
