using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyDBInitializer_DataAnnotationsExample : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var alias = new List<Alias_DataAnnotationsExample>
            {
                new Alias_DataAnnotationsExample
                {
                    Name = "testName", Bio = "TestBio", UserName = "Test User Name", Email = "test@test.com", CreateDate = DateTime.Now,
                    Tweets = new List<Tweet_DataAnnotationsExample> {new Tweet_DataAnnotationsExample {Content = "Test tweets content", CreateDate = DateTime.Now } },
                    Privacy = new Privacy_DataAnnotationsExample {Test = 1 }
                }
            };

            context.Aliases.AddRange(alias);

            base.Seed(context);
        }
    }
}
