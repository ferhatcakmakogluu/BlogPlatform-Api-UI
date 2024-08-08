using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IPicturesService : IService<Pictures>
    {
        Task<List<PictureWithCommentsDto>> GetPictureWithComments();
        Task<PictureWithCommentsDto> GetPictureWithCommentsById(int pictureId);
    }
}
