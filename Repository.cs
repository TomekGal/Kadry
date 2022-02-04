﻿using Kadry.Models.Domains;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Kadry.Models.Wrappers;
using Kadry.Converters;


namespace Kadry
{
   public class Repository
    {

        public List <Status> GetStatuses()
        {

            using (var context = new ApplicationDbContext())
            {
                return context.Statuses.ToList();
            }
        }

        public List<EmployeeWrapper> GetEmployees(int statusId)
        {
            using (var context= new ApplicationDbContext ())
            {
                var employees= context.Employees.Include(x=>x.Status ).AsQueryable();

                if (statusId!=0)
                
                    employees = employees.Where(x => x.StatusId == statusId);

                return employees
                    .ToList()
                    .Select(x=>x.ToWrapper())
                    .ToList();
            }

        }

       public int CheckEmployeeId()
        {
            using (var context = new ApplicationDbContext())
            {
                var EmployeeId = context.Employees.Select(x=>x.EmployeeId);

                return EmployeeId.Max();
               
            }
        }
        public void DismissEmployee(int id)
        {
           
            using (var context = new ApplicationDbContext())
            {
                var employeeToDismiss = context.Employees.Find(id);
               employeeToDismiss.StatusId=2;
                context.SaveChanges();
            }
        }

        public void AddEmployee(EmployeeWrapper employeeWrapper)
        {
            var employee = employeeWrapper.ToDao();
            using (var context= new ApplicationDbContext ())
            { 
                
               var dbEmployee= context.Employees.Add(employee);
               
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(EmployeeWrapper employeeWrapper)
        {

            var employee = employeeWrapper.ToDao();

            using (var context= new ApplicationDbContext ())
            {

                UpdateEmployeeProperties(context, employee);
               
                context.SaveChanges();
            }
            
        }

        private void UpdateEmployeeProperties(ApplicationDbContext context, Employee employee)
        {
            var employeeToUpdate = context.Employees.Find(employee.Id);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Salary = employee.Salary;
            employeeToUpdate.StartDate = employee.StartDate;
            employeeToUpdate.EndDate = employee.EndDate;
             employeeToUpdate.StatusId = employee.StatusId;
            employeeToUpdate.Comments = employee.Comments;
                      
        }

        public void InitStatuses()
        {

            using (var context = new ApplicationDbContext())

            {
                if (context.Statuses.Any() == false)
                {
                    context.Statuses.Add(new Status { Id = 0, Name = "wszyscy" });
                    context.Statuses.Add(new Status { Id = 1, Name = "zatrudniony" });
                    context.Statuses.Add(new Status { Id = 2, Name = "zwolniony" });

                    context.SaveChanges();

                }
                //return context.Statuses.ToList();
            }

        }
    }
}
