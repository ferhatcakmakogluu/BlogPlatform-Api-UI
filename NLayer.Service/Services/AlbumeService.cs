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
    public class AlbumeService : Service<Albume>, IAlbumeService
    {
        private readonly IAlbumeRepository _albumeRepository;
        private readonly IMapper _mapper;
        public AlbumeService(IGenericRepository<Albume> repository, IUnitOfWork unitOfWork, IMapper mapper, IAlbumeRepository albumeRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _albumeRepository = albumeRepository;
        }

        public async Task<List<AlbumeWithPicturesDto>> GetAllAlbumeWithPictures()
        {
            var data = await _albumeRepository.GetAlbumeWithPictures();
            var dataDto = _mapper.Map<List<AlbumeWithPicturesDto>>(data);
            return dataDto;
        }
    }
}
