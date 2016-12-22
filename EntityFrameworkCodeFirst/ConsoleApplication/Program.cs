using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void RunExampleForBlog()
        {
            var blog = new Blog { BloggerName = "Janek Testowy", Title = "Testowy tytulik" };

            var context = new Context();

            context.Blogs.Add(blog);

            context.SaveChanges();
        }
    }
}
