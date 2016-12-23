using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Alias_DataAnnotationsExample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] Avatar { get; set; }
        public ICollection<Tweet_DataAnnotationsExample> Tweets { get; set; }
    }
}
