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
        [Key, Column(Order = 0)]
        public int RandomKey { get; set; }

        //[Required, ConcurrencyCheck]
        [Required]
        public string Name { get; set; }

        [MaxLength(20), MinLength(5)]
        public string UserName { get; set; }

        [MinLength(5)]
        public string Email { get; set; }

        public string Bio { get; set; }

        [Column("DateStarted", Order = 2, TypeName = "date")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreateDate { get; set; }

        public byte[] Avatar { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<Tweet_DataAnnotationsExample> Tweets { get; set; }

        [NotMapped]
        public string Abbrevation
        {
            get
            {
                return UserName.Substring(0, 1);
            }
        }

        public Privacy_DataAnnotationsExample Privacy { get; set; }

        [InverseProperty("Admin")]
        public ICollection<Person> Admins { get; set; }
        [InverseProperty("Users")]
        public ICollection<Person> Users { get; set; }
    }

    [ComplexType]
    public class Privacy_DataAnnotationsExample
    {
        public int Test { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Alias_DataAnnotationsExample Admin { get; set; }
        public Alias_DataAnnotationsExample Users { get; set; }
    }
}
