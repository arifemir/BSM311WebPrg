using food.DataAccess;
using food.DataAccess.Data.Repository;
using food.DataAccess.Data.Repository.IRepository;
using food.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Taste.DataAccess.Data.Repository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public FoodTypeRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetFoodTypeListForDropDown()
        {
            return _db.FoodType.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }


        public void Update(FoodType objectToBeUpdated)
        {
            var categoryFromDb = _db.FoodType.FirstOrDefault(s => s.Id == objectToBeUpdated.Id);
            categoryFromDb.Name = objectToBeUpdated.Name;
            _db.SaveChanges();
        }

    }
}