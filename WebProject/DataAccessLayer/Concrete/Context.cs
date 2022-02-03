using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilde)
        {
            optionsBuilde.UseSqlServer("server=LAPTOP-K9OQTN1D\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;"); 
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLatter> NewsLatters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
    }
}
