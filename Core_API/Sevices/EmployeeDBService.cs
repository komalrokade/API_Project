using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;

namespace Core_API.Models.Sevices
{
    public class EmployeeDBService : IDBService<Employee, int>
    {
        private readonly CompanyContext context;
        public EmployeeDBService(CompanyContext ctx)
        {
            context = ctx;
        }
        public Employee Create(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();
            return entity;

            //throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            var empToDelete = context.Employees.Find(id);
            if (empToDelete == null) return null;

            context.Employees.Remove(empToDelete);
            context.SaveChanges();
            return empToDelete;
            //throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            return context.Employees.ToList();
            //throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            var empToFind = context.Employees.Find(id);
            return empToFind;

            //throw new NotImplementedException();
        }

        public Employee Update(int id, Employee entity)
        {
            var empToUpdate = context.Employees.Find(id);
            if (empToUpdate == null) return null;

            empToUpdate.EmpNo = entity.EmpNo;
            empToUpdate.EmpName = entity.EmpName;
            empToUpdate.Designation = entity.Designation;
            empToUpdate.Salary = entity.Salary;
            empToUpdate.DeptNo = entity.DeptNo;

            context.SaveChanges();
            return empToUpdate;
            //throw new Not
        }
    }
}
