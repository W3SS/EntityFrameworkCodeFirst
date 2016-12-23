using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyDBInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            List<Blog> blogs = new List<Blog>
            {
                new Blog
                {
                    BloggerName = "test name",
                    DateOfCreation = DateTime.Now,
                    Posts = new List<Post> {new Post { Content = "test content", Title = "Test title"} },
                    Title = "Test title"
                },
                new Blog
                {
                    BloggerName = "test name2",
                    DateOfCreation = DateTime.Now,
                    Title = "Title2"
                }
            };

            blogs.ForEach(x => context.Blogs.Add(x));

            base.Seed(context);
        }
    }
}
