using Kadry.Models.Domains;
using Kadry.Models.Wrappers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry.Models.Configurations
{
  public  class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("dbo.Employees");
            HasKey(x => x.Id);
        }
    }
}
