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
            Database.SetInitializer(new MyDBInitializer());

            RunExampleForBlog();
            RunExampleForPost();
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
    }
}
