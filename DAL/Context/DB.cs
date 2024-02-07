using BE.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DB : DbContext, IDisposable
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=myDataBase;Encrypt=True;user=sa; password=1; TrustServerCertificate=True;");
        }

        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<NewsLatter> newsLatters { get; set; }
        public DbSet<BlogRayting> blogRaytings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable(tb => tb.HasTrigger("AddBlogInRatingTable"));
            modelBuilder.Entity<Comment>().ToTable(tb => tb.HasTrigger("AddScoreInComment"));
        }
        public void Dispose()
        {
            base.Dispose();
        }

    }
}
