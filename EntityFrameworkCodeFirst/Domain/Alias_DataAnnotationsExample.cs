using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("AliasName")]
    public class Alias_DataAnnotationsExample
    {
        [Key]
        public int AliasKey { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(20), MinLength(5)]
        public string UserName { get; set; }

        [MinLength(5)]
        public string Email { get; set; }

        public string Bio { get; set; }

        [Column("DateStarted", Order = 2)]
        public DateTime CreateDate { get; set; }

        public byte[] Avatar { get; set; }

        public ICollection<Tweet_DataAnnotationsExample> Tweets { get; set; }
    }
}
