using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course :Entity<int>
    {
        public Course()
        {
            
        }
        public string Title { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Instructor Instructor { get; set; }  //bir kurs bir eğitmene ait olmalı
    }
}
