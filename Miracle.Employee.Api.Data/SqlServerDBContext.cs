using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miracle.Employee.Api.Entities.Models;

namespace Miracle.Employee.Api.Data
{
   public  class SqlServerDBContext : DbContext
    {
		//dbcontext connection with employinfo table
        public SqlServerDBContext(DbContextOptions<SqlServerDBContext> options) : base(options)
        {

        }
        public SqlServerDBContext()
        {

        }
		
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
    }
}
