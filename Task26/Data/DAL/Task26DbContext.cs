using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task26.Data.Entities;

namespace Task26.Data.DAL
{
    internal class Task26DbContext:DbContext
    {
        public DbSet<Stadiums> Stadiums { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=BEXININSIRINNOT\SQLEXPRESS;Database=Task26_1;Trusted_Connection=TRUE");
        }
        

    }
}
