using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        //Constructor
        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
