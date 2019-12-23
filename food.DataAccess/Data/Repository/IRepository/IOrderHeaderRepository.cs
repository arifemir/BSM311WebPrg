using System;
using System.Collections.Generic;
using System.Text;
using food.Models;

namespace food.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
