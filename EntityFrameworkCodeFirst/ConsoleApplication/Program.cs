using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new MyDBInitializer());
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());

            //RunExampleForBlog();
            //RunExampleForPost();

            //Database.SetInitializer(new MyDBInitializer_DataAnnotationsExample());

            //RunSimpleForAllias();

            RunExampleForAliasFluentConfig();
        }

        public static void RunExampleForBlog()
        {
            var blog = new Blog { BloggerName = "Janek Testowy", Title = "Testowy tytulik", DateOfCreation = DateTime.Now };

            var context = new Context();

            context.Blogs.Add(blog);

            context.SaveChanges();
        }

        public static void RunExampleForPost()
        {
            var context = new Context();
            var persistenceBlog = context.Blogs.Find(1);
            var post = new Post { Blog = persistenceBlog, Title = "Post title", Content = "Test content" };

            context.Posts.Add(post);
            context.SaveChanges();
        }

        public static void RunSimpleForAllias()
        {
            var context = new Context();
            var alias = new Alias_DataAnnotationsExample { Name = "Test", CreateDate = DateTime.Now, Privacy = new Privacy_DataAnnotationsExample { Test = 2 } };
            context.Aliases.Add(alias);
            context.SaveChanges();
        }

        public static void RunExampleForAliasFluentConfig()
        {
            var context = new Context();
            var alias = new Alias_FluentConfig { Name = "Test", CreateDate = DateTime.Now, Privacy = new Privacy_FluentConfig { Test = "test value" } };

            context.Aliases_FluentConfig.Add(alias);

            context.SaveChanges();
        }
    }
}
