using Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment6.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PagingInfo PagingInfo { get; set;  }

        // allows for organizng books by category (Historical, Self Help, etc)
        public string Type { get; set; }
    }
}

