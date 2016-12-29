using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Simple_DataAnnotationsExample
    {
        [Key, Column(Order = 1)]
        public int RandomKey { get; set; }
        [Key, Column(Order = 2)]
        public int RandomKey2 { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(20)]
        [ConcurrencyCheck]
        public string UserName { get; set; }
        
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
