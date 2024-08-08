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
    public class NewsService : Service<News>, INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;
        public NewsService(IGenericRepository<News> repository, IUnitOfWork unitOfWork, IMapper mapper, INewsRepository newsRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _newsRepository = newsRepository;
        }

        public async Task<List<NewsWithCommentsDto>> GetNewsWithComments()
        {
            var data = await _newsRepository.GetNewsWithComments();
            var dataDto = _mapper.Map<List<NewsWithCommentsDto>>(data);
            return dataDto;
        }

        public async Task<NewsWithCommentsDto> GetNewsWithCommentsById(int newsId)
        {
            var data = await _newsRepository.GetNewsWithCommentsById(newsId);
            var dataDto = _mapper.Map<NewsWithCommentsDto>(data);
            return dataDto;
        }
    }
}
