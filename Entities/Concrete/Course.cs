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
        public string Name { get; set; }

        // Bir kursun bir kategorisi olabilir
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int InstructorId { get; set; }

        //bir kurs bir eğitmene ait olmalı
        public Instructor Instructor { get; set; }  
        

        public ICollection<Category> Categories { get; set; }
    }
}
