using food.DataAccess.Data.Repository.IRepository;
using food.Models;
using System.Linq;

namespace food.DataAccess.Data.Repository
{


    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuItemRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }


        public void Update(MenuItem menuItem)
        {
            var menuItemFromDb = _db.MenuItem.FirstOrDefault(m => m.Id == menuItem.Id);
            menuItemFromDb.Name = menuItem.Name;
            menuItemFromDb.CategoryId = menuItem.CategoryId;

            menuItemFromDb.Description = menuItem.Description;
            menuItemFromDb.FoodTypeId = menuItem.FoodTypeId;
            if (menuItem.Image != null)
            {
                menuItemFromDb.Image = menuItem.Image;
            }
            menuItemFromDb.Price = menuItem.Price;

            _db.SaveChanges();


        }
    }
}
