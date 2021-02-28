using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;
using Assignment5.Controllers;

namespace Assignment6.Components
{

    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];


            return View(repository.Projects
                .Select( x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
