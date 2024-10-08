﻿using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IAlbumeService : IService<Albume>
    {
        Task<List<AlbumeWithPicturesDto>> GetAllAlbumeWithPictures();
        Task<AlbumeWithPicturesDto> GetAllAlbumeWithPicturesById(int albumeId);
        Task<List<AlbumeWithPicturesAndCommentsDto>> GetAlbumeWithPicturesAndComments();
    }
}
