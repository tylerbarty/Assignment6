﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booksite.Models;
using Booksite.Controllers;

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


            return View(repository.Books
                .Select( x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
