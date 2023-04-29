using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OptimizeMePlease.Entities;
using System;

namespace OptimizeMePlease.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var sqlConnectionString = @"Server=localhost,1433;Database=OptimizeMePlease;User Id=sa;Password=yourStrong(!)Password;Encrypt=false";
            options.UseSqlServer(sqlConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}