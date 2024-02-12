using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miracle.Employee.Api.Entities.Models;
using Miracle.Employee.Api.Data;
using Miracle.Employee.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Miracle.Employee.Api.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlServerDBContext _sqlServerDBContext;
        public EmployeeRepository(SqlServerDBContext sqlServerDBContext)
        {
            _sqlServerDBContext = sqlServerDBContext;
        }
        public async Task<IEnumerable<EmployeeInfo>> GetEmployees()
        {
            return await _sqlServerDBContext.EmployeeInfo.ToListAsync();
        }

        public async Task<EmployeeInfo> GetEmployee(int employeeId)
        {
            return await _sqlServerDBContext.EmployeeInfo
                .FirstOrDefaultAsync(e => e.ID == employeeId);
        }

        public async Task<EmployeeInfo> AddEmployee(EmployeeInfo employee)
        {
            var result = await _sqlServerDBContext.EmployeeInfo.AddAsync(employee);
            await _sqlServerDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<EmployeeInfo> UpdateEmployee(EmployeeInfo employee)
        {
            var result = await _sqlServerDBContext.EmployeeInfo
                .FirstOrDefaultAsync(e => e.ID == employee.ID);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.Designation = employee.Designation;
                result.Salary = employee.Salary;
                result.Phone = employee.Phone;
                result.City = employee.City;

                await _sqlServerDBContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<EmployeeInfo> DeleteEmployee(int employeeId)
        {
            var result = await _sqlServerDBContext.EmployeeInfo
                .FirstOrDefaultAsync(e => e.ID == employeeId);
            if (result != null)
            {
                _sqlServerDBContext.EmployeeInfo.Remove(result);
                await _sqlServerDBContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
        //public IEnumerable<EmployeeRepository> GetEmployees()
        //{
        //    return _sqlServerDBContext.employees;

        //}
        //public EmployeeRepository AddEmployee(EmployeeRepository employee)
        //{

        //}
        //public EmployeeRepository EditEmployee(EmployeeRepository employee)
        //{

        //}
        //public EmployeeRepository DeleteEmployee(int id)
        //{

        //}
        //public EmployeeRepository GetEmployeeId(int id)
        //{

        //}
    }
}
