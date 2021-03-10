﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booksite.Models;
using Microsoft.AspNetCore.Mvc;

// this class is a simple constructor 
namespace Booksite.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
