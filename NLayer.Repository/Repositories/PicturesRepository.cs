using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class PicturesRepository : GenericRepository<Pictures>, IPictureRepository
    {
        private readonly AppDbContext _context;
        public PicturesRepository(AppDbContext dbContext, AppDbContext context) : base(dbContext)
        {
            _context = context;
        }

        public async Task<List<Pictures>> GetPictureWithComments()
        {
            return await _context.Pictures.Include(x=>x.PictureComments).ToListAsync();
        }
    }
}
