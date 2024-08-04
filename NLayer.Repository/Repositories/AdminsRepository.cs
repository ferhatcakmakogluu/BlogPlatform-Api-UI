using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class AdminsRepository : GenericRepository<Admins>, IAdminRepository
    {
        public AdminsRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
