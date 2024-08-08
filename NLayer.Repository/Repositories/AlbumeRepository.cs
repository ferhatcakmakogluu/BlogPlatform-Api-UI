using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class AlbumeRepository : GenericRepository<Albume>, IAlbumeRepository
    {
        private readonly AppDbContext _context;
        public AlbumeRepository(AppDbContext contex, AppDbContext context) : base(contex)
        {
            _context = context;
        }

        public async Task<List<Albume>> GetAlbumeWithPictures()
        {
            return await _context.Albumes.Include(x=> x.Pictures).ToListAsync();
        }

        public async Task<Albume> GetAlbumeWithPicturesById(int albumeId)
        {
            return await _context.Albumes.Include(x => x.Pictures).Where(x => x.Id == albumeId).FirstOrDefaultAsync();
        }
    }
}
