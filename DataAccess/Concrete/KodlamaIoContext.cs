using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class KodlamaIoContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public KodlamaIoContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { 
        
           
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Category) 
                .WithMany(cat => cat.Courses) 
                .HasForeignKey(c => c.CategoryId); 


            base.OnModelCreating(modelBuilder);
        }

    }
}
