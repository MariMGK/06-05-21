using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication14.Controllers
{
    public class EmployeeController : ApiController
    {
        public class Employee
        {
            public int EmpId { get; set; }
            public string EmployeeName { get; set; }
            public string Designation { get; set; }
            public decimal Salary { get; set; }
        }
        Employee[] Employees = new Employee[]{
            new Employee {EmpId=1,EmployeeName="John", Designation="Software Engineer", Salary=78000},
            new Employee {EmpId=2,EmployeeName="Kim", Designation="Software Engineer", Salary=72000},
            new Employee {EmpId=3,EmployeeName="Peter", Designation="Software Engineer", Salary=75000},
            new Employee {EmpId=4,EmployeeName="Pratik", Designation="Software Engineer", Salary=55000},
            new Employee {EmpId=5,EmployeeName="Nikunj", Designation="Software Engineer", Salary=42000},
            new Employee {EmpId=6,EmployeeName="Sarah", Designation="Software Engineer", Salary=90000}
        };
        public IEnumerable<Employee>  GetAllEmployees()
        {
            return Employees;
        }
        public IHttpActionResult Get(int Id)
        {
            var Employee = Employees.FirstOrDefault((e) => e.EmpId == Id);
                if(Employee==null)
            {
                return NotFound();
            }
            return Ok(Employee);
        }
    }
}
