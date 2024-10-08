﻿using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface INewsRepository : IGenericRepository<News>
    {
        Task<List<News>> GetNewsWithComments();
        Task<News> GetNewsWithCommentsById(int newsId);
    }
}
