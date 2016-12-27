using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product_FluentConfig
    {
        public int Id { get; set; }
        public string Name {get;set;}
        public string Type { get; set; }
        public string AdditionalInfo { get; set; }
        public virtual Employee_FluentConfig Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
