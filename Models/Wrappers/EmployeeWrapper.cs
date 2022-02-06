
using Kadry.Models.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadry.Models.Wrappers
{
    public class EmployeeWrapper : IDataErrorInfo
    {
        public EmployeeWrapper()
        {
            Status = new Status();
        }


        public int Id { get; set; }

        public int  EmployeeId { get; set; }
      

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Comments { get; set; }

        public Status Status { get; set; }

        private bool _isFirstNameValid;
        private bool _isLastNameValid;
        


        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(FirstName):
                        if (string.IsNullOrWhiteSpace(FirstName))
                        {
                            Error = "Pole Imię jest wymagane";
                            _isFirstNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isFirstNameValid = true;
                        }
                        break;
                    case nameof(LastName):
                        if (string.IsNullOrWhiteSpace(LastName))
                        {
                            Error = "Pole Nazwisko jest wymagane";
                            _isLastNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isLastNameValid = true;
                        }
                        break;
                    default:
                        break;
                }
                return Error;
            }
        }

        public string Error
        {
            get; set;
        }

        public bool IsValid
        {
            get
            {
                return _isFirstNameValid && _isLastNameValid ;
            }

        }

        public bool IsUpdate { get; private set; }
    }
}
