﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilde)
        {
            optionsBuilde.UseSqlServer("server=LAPTOP-K9OQTN1D\\SQLEXPRESS;database=CoreBlogApiDb;integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
