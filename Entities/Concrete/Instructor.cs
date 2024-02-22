using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor : Entity<int>
    {
        public Instructor()
        {
        }

        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
