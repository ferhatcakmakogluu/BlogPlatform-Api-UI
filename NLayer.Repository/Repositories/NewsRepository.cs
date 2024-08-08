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
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        private readonly AppDbContext _context;
        public NewsRepository(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<News>> GetNewsWithComments()
        {
            return await _context.News.Include(x=> x.NewsComments).ToListAsync();
        }

        public async Task<News> GetNewsWithCommentsById(int newsId)
        {
            return await _context.News.Include(x => x.NewsComments).Where(x => x.Id == newsId).FirstOrDefaultAsync();
        }
    }
}
