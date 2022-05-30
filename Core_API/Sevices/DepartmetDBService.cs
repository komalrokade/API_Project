using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models.Sevices;

namespace Core_API.Models.Sevices
{
    public class DepartmetDBService : IDBService<Department, int>
    {
        private readonly CompanyContext context;
        public DepartmetDBService(CompanyContext ctx)
        {
            context = ctx;
        }
        public Department Create(Department entity)
        {
            context.Departments.Add(entity);
            context.SaveChanges();
            return entity;

            //throw new NotImplementedException();
        }

        public Department Delete(int id)
        {
            var deptToDelete = context.Departments.Find(id);
            if (deptToDelete == null) return null;

            context.Departments.Remove(deptToDelete);
            context.SaveChanges();
            return deptToDelete;
            //throw new NotImplementedException();
        }

        public IEnumerable<Department> Get()
        {
            return context.Departments.ToList();
            //throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            var deptToFind = context.Departments.Find(id);
            return deptToFind;

            //throw new NotImplementedException();
        }

        public Department Update(int id, Department entity)
        {
            var deptToUpdate = context.Departments.Find(id);
            if (deptToUpdate == null) return null;

            deptToUpdate.DeptName = entity.DeptName;
            deptToUpdate.Location = entity.Location;
            deptToUpdate.Capacity = entity.Capacity;
            context.SaveChanges();
            return deptToUpdate;
            //throw new NotImplementedException();
        }
    }
}
