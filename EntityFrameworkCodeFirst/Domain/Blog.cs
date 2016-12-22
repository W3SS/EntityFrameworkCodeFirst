using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Blog
    {
        public int Id { get; set; }

        public string BloggerName { get; set; }

        public string Title { get; set; }

        public List<Post> Posts { get; set; }
    }
}
