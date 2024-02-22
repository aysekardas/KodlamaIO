using Core.Entities;
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
        // Bir kategoride birden fazla kurs olabilir
        public ICollection<Course> Courses { get; set; } = null;
    }
}
