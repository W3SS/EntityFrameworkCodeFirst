using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product_FluentConfig>
    {
        public ProductConfiguration()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired();
            this.Property(p => p.Type).IsRequired();
            this.Property(p => p.AdditionalInfo).IsOptional();
            this.HasRequired(p => p.Employee).WithMany(x => x.Products).HasForeignKey(f => f.EmployeeId);
        }
    }
}
