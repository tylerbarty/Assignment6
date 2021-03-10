﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booksite.Models;

namespace Booksite.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        //Constructor
        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;

    }
}
