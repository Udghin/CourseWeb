using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class NoticesDbContext : DbContext
    {
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Category> Category { get; set; }
         public NoticesDbContext(DbContextOptions options) : base(options)
        {
          //  Database.EnsureDeleted();
          //  Database.EnsureCreated();
        }
    }
}
