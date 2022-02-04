using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry.Models.Wrappers
{
  public  class StatusWrapper
    {
        public StatusWrapper()
        {
            Employee = new Collection<EmployeeWrapper>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<EmployeeWrapper> Employee { get; set; }
    }
}
