using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;

namespace Core_API.Models.Sevices
{
    public class EmployeeDBService : IDBService<Employee, int>
    {
        //private readonly CompanyContext context;
        public Employee Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
