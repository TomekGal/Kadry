using System;


namespace Kadry.Models.Domains
{
  public  class Employee
    {
        public int Id { get; set; }

        public int EmployeeId 
        { get;
            set; 
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime? StartDate { get; set; }
       
        public DateTime? EndDate { get; set; }
               
        public int StatusId { get; set; }

        public string Comments { get; set; }

        public Status Status { get; set; }
    }
}
