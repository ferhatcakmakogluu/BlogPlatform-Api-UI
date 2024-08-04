using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class AdminService : Service<Admins>, IAdminService
    {
        public AdminService(IGenericRepository<Admins> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
