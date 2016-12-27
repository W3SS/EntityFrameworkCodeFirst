using DataLayer.Configurations;
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
        public DbSet<Alias_DataAnnotationsExample> Aliases { get; set; }
        public DbSet<Tweet_DataAnnotationsExample> Tweets { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Alias_FluentConfig> Aliases_FluentConfig { get; set; }
        public DbSet<Tweet_FluentConfig> Tweet_FluentConfig { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Alias_FluentConfig>().ToTable("Alias_FluentConfiguration", "FulentConfig");
            modelBuilder.Entity<Alias_FluentConfig>().HasKey(p => p.AliasKey);
            modelBuilder.Entity<Tweet_FluentConfig>().HasKey(p => p.AliasKey);
            modelBuilder.Entity<Alias_FluentConfig>()
                .Property(p => p.CreateDate)
                .HasColumnName("StartDate")
                //.HasColumnOrder(3)
                .HasColumnType("date")
                .IsRequired();
            modelBuilder.Entity<Alias_FluentConfig>()
                .Property(p => p.Name).HasColumnName("FullName");
                //.IsFixedLength() //in db is nchar type
                //.IsMaxLength();
            modelBuilder.ComplexType<Privacy_FluentConfig>().Property(p => p.Test).HasColumnName("TestingPrivacy");
            modelBuilder.Ignore<PrivacyToIgnore_FluentConfig>();

            ////--------------------------------------------------------------------------------------
            //// if you would like to use bottom configuration with Alias_FluentConfig as split entity
            //// you should comment code above. 
            //// Because you mapping entity Alias_FluentConfig not once!
            ////--------------------------------------------------------------------------------------
            ////modelBuilder.Entity<Alias_FluentConfig>()
            ////    .Map(mapping =>
            ////    {
            ////        mapping.Properties(p => new { p.AliasKey, p.UserName });
            ////        mapping.ToTable("AliasFirstTable");

            ////    })
            ////    .Map(mapping =>
            ////    {
            ////        mapping.Properties(p => new { p.AliasKey, p.Email });
            ////        mapping.ToTable("AliasSecondTable");
            ////    });
            ////modelBuilder.Ignore<PrivacyToIgnore_FluentConfig>();

            //modelBuilder.Entity<Tweet_FluentConfig>()
            //    .Map(mapping =>
            //    {
            //        mapping.Properties(p => new
            //        {
            //            p.Id,
            //            p.Content
            //        });
            //        mapping.ToTable("TweeterFirst");
            //    })
            //    .Map(mapping =>
            //    {
            //        mapping.Properties(p => new
            //        {
            //            p.Id,
            //            p.CreateDate
            //        });
            //        mapping.ToTable("TweeterSc");
            //    });

            modelBuilder.Entity<Alias_FluentConfig>().ToTable("TwiiterAliases");
            modelBuilder.Entity<Tweet_FluentConfig>().ToTable("TwiiterAliases");
            modelBuilder.Entity<Alias_FluentConfig>().HasRequired(p => p.TweetWithLazyLoading).WithRequiredPrincipal();

            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
        }
    }
}
