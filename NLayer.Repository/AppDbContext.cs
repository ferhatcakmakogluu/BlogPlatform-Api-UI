﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {  
        }

        DbSet<Admins> Admins { get; set; }
        DbSet<Albume> Albumes { get; set; }
        DbSet<News> News { get; set; }
        DbSet<NewsComments> NewsComments { get; set; }
        DbSet<PictureComments> PictureComments { get; set; }
        DbSet<Pictures> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}