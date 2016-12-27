using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tweet_FluentConfig
    {
        public int AliasKey { get; set; }
        //public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        public Alias_FluentConfig Alias { get; set; }
        public byte[] Avatar { get; set; }
        //public int AliasId { get; set; }
    }
}
