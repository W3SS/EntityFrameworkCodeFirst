using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee_FluentConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product_FluentConfig> Products { get; set; }
    }
}
