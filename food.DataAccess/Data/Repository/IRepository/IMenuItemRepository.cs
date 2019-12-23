using food.Models;

namespace food.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {


        void Update(MenuItem menuItem);
    }
}
