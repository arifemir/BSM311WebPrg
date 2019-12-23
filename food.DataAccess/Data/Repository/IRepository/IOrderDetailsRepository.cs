using System;
using System.Collections.Generic;
using System.Text;
using food.Models;

namespace food.DataAccess.Data.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
