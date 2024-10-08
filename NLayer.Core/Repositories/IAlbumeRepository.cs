﻿using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IAlbumeRepository : IGenericRepository<Albume>
    {
        Task<List<Albume>> GetAlbumeWithPictures();
        Task<Albume> GetAlbumeWithPicturesById(int albumeId);
        Task<List<AlbumeWithPicturesAndCommentsDto>> GetAlbumeWithPicturesAndCommentsAsync();
    }
}
