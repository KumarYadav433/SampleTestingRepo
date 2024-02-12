using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miracle.Employee.Api.Entities.Models;

namespace Miracle.Employee.Api.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeInfo>> GetEmployees();
        Task<EmployeeInfo> GetEmployee(int employeeId);
        Task<EmployeeInfo> AddEmployee(EmployeeInfo employee);
        Task<EmployeeInfo> UpdateEmployee(EmployeeInfo employee);
        Task<EmployeeInfo> DeleteEmployee(int employeeId);
        //void DeleteEmployee(int employeeId);
        //public IEnumerable<Employee> GetEmployees();
        //public Employee AddEmployee(Employee employee);
        //public Employee EditEmployee(Employee employee);
        //public Employee DeleteEmployee(int id);
        //public Employee GetEmployeeId(int id);

    }
}
