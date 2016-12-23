using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tweet_DataAnnotationsExample
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        [ForeignKey("AliasId")]
        public Alias_DataAnnotationsExample Alias { get; set; }
        public int AliasId { get; set; }
    }
}
