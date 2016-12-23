using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Blog
    {
        [Column("RandomKey")]
        public int Id { get; set; }

        public string BloggerName { get; set; }

        public string Title { get; set; }

        public DateTime DateOfCreation { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public List<Post> Posts { get; set; }
    }
}
