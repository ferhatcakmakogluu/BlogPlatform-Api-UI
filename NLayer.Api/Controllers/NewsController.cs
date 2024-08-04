using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class NewsController : CustomBaseController
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;

        public NewsController(INewsService newsService, IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNews()
        {
            var news = await _newsService.GetAllAsync();
            var newsDto = _mapper.Map<List<NewsDto>>(news);
            return CreateActionResult(CustomResponseDto<List<NewsDto>>.Success(200, newsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            var news = await _newsService.GetByIdAsync(id);
            var newsDto = _mapper.Map<NewsDto>(news);
            return CreateActionResult(CustomResponseDto<NewsDto>.Success(200, newsDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveNews(NewsDto newsDto)
        {
            await _newsService.AddAsync(_mapper.Map<News>(newsDto));
            return CreateActionResult(CustomResponseDto<NewsDto>.Success(201,newsDto));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveRangeNews(List<NewsDto> newsDto)
        {
            await _newsService.AddRangeAsync(_mapper.Map<List<News>>(newsDto));
            return CreateActionResult(CustomResponseDto<List<NewsDto>>.Success(201, newsDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNews(NewsDto newsDto)
        {
            await _newsService.Update(_mapper.Map<News>(newsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNews(int id)
        {
            var news = await _newsService.GetByIdAsync(id);
            await _newsService.Remove(news);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
