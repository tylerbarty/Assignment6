using Booksite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksite.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set;  }

        // allows for organizng books by category (Historical, Self Help, etc)
        public string Type { get; set; }
    }
}

