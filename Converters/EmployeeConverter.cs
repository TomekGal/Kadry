using Kadry.Models.Domains;
using Kadry.Models.Wrappers;


namespace Kadry.Converters
{
   public static class EmployeeConverter
    {
        public static EmployeeWrapper ToWrapper(this Employee model)
        {

            return new EmployeeWrapper

            {
                Id = model.Id,
                EmployeeId = model.EmployeeId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Salary = model.Salary,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Status = new Status
                {
                    Id = model.Status.Id,
                    Name = model.Status.Name
                },
                Comments = model.Comments,

            };
        }
            public static Employee ToDao(this EmployeeWrapper model)
            {

                return new Employee
                {
                    Id =model.Id,
                    EmployeeId = model.EmployeeId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Salary = model.Salary,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    StatusId =model.Status.Id ,
                    Comments = model.Comments,
                };
            }

        
    }
}
