using System;
using System.Collections.Generic;
using System.Text;
using food.DataAccess.Data.Repository.IRepository;
using food.Models;

namespace food.DataAccess.Data.Repository
{
    public class ApplicationUserRepository:Repository<ApplicationUser>,IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
