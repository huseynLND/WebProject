﻿using hometask112124.Models;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;

namespace hometask112124.DataAccess
{
    public class UniqloDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public UniqloDbContext(DbContextOptions opt) : base(opt) 
        {
            
        }
    }

}
