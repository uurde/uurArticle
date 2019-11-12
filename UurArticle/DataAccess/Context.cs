﻿using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = 77.223.142.42; Initial Catalog = UgurDegirmenci; Persist Security Info = False; User ID = uurde; Password =0734ypkEUZ87; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = True; Connection Timeout = 30;");
        }

        public DbSet<BlogArticle> BlogArticles { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogUser> BlogUsers { get; set; }
    }
}