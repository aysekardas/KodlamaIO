﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : Entity<int>
    {
        public Category()
        {
            
        }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; } = null;
    }
}
