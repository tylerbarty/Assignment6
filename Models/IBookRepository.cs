﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<Project> Projects { get;  }
    }
}
