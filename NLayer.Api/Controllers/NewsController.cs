using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Api.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;
using NLayer.Service.Services;

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

        [ServiceFilter(typeof(NotFoundServiceFilter<News>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            var news = await _newsService.GetByIdAsync(id);
            var newsDto = _mapper.Map<NewsDto>(news);
            return CreateActionResult(CustomResponseDto<NewsDto>.Success(200, newsDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetNewsWithComments()
        {
            var data = await _newsService.GetNewsWithComments();
            return CreateActionResult(CustomResponseDto<List<NewsWithCommentsDto>>.Success(200, data));
        }

        [ServiceFilter(typeof (NotFoundServiceFilter<News>))]
        [HttpGet("[action]/{newsId}")]
        public async Task<IActionResult> GetNewsWithCommentsById(int newsId)
        {
            var data = await _newsService.GetNewsWithCommentsById(newsId);
            return CreateActionResult(CustomResponseDto<NewsWithCommentsDto>.Success(200, data));
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

        [ServiceFilter(typeof(NotFoundServiceFilter<News>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNews(int id)
        {
            var news = await _newsService.GetByIdAsync(id);
            await _newsService.Remove(news);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMergeNews(List<NewsDto> newsDtos)
        {
            await _newsService.RemoveMerge(_mapper.Map<List<News>>(newsDtos));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
