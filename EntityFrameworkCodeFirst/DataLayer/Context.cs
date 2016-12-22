using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Context : DbContext
    {
        public Context()
            : base()
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasKey(m => m.Id);
            modelBuilder.Entity<Blog>().Property(m => m.Title).HasMaxLength(20);
            modelBuilder.Entity<Blog>().Property(m => m.BloggerName).IsRequired();

            //modelBuilder.Entity<Blog>().Map(mapp =>
            //{
            //    mapp.Property(p => p.Title).HasColumnName("BlogTitle");
            //    mapp.Property(p => p.BloggerName);
            //});

            modelBuilder.Entity<Post>().HasKey(m => m.Id);
            modelBuilder.Entity<Post>().Property(m => m.Content).HasMaxLength(100);
            modelBuilder.Entity<Post>().Property(m => m.Title).HasMaxLength(20);

            base.OnModelCreating(modelBuilder);
        }
    }
}
