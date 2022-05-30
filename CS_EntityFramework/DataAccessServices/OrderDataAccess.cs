using CS_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EntityFramework.DataAccessServices
{
    class OrderDataAccess : IDataAccess<Order, int>
    {
        public Order Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Get()
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order Update(int id, Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
