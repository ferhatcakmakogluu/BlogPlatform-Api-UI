using AutoMapper;
using NLayer.Core.DTOs;
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
    public class PicturesService : Service<Pictures>, IPicturesService
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly IMapper _mapper;
        public PicturesService(IGenericRepository<Pictures> repository, IUnitOfWork unitOfWork, IMapper mapper = null, IPictureRepository pictureRepository = null) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _pictureRepository = pictureRepository;
        }

        public async Task<List<PictureWithComments>> GetPictureWithComments()
        {
            var data = await _pictureRepository.GetPictureWithComments();
            var dataDto = _mapper.Map<List<PictureWithComments>>(data);
            return dataDto;
        }

        public async Task<PictureWithComments> GetPictureWithCommentsById(int pictureId)
        {
            var data = await _pictureRepository.GetPictureWithCommentsById(pictureId);
            var dataDto = _mapper.Map<PictureWithComments>(data);
            return dataDto;
        }
    }
}
