﻿using Kadry.Models.Wrappers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry.Models.Domains
{
   public class Status
    {
        public Status()
        {
            Employees = new Collection<Employee>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
