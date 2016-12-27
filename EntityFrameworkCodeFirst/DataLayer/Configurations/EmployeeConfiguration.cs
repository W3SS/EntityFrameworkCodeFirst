using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee_FluentConfig>
    {
        public EmployeeConfiguration()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired();
        }
    }
}
