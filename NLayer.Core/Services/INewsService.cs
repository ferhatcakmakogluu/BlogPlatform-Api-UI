﻿using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface INewsService : IService<News>
    {
        Task<List<NewsWithCommentsDto>> GetNewsWithComments();
        Task<NewsWithCommentsDto> GetNewsWithCommentsById(int newsId);
    }
}
