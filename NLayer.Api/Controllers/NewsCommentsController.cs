using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class NewsCommentsController : CustomBaseController
    {
        private readonly INewsCommentsService _newsCommentsService;
        private readonly IMapper _mapper;

        public NewsCommentsController(INewsCommentsService newsCommentsService, IMapper mapper)
        {
            _newsCommentsService = newsCommentsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _newsCommentsService.GetAllAsync();
            var commentsDto = _mapper.Map<List<NewsCommentsDto>>(comments);
            return CreateActionResult(CustomResponseDto<List<NewsCommentsDto>>.Success(200,commentsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _newsCommentsService.GetByIdAsync(id);
            var commentDto = _mapper.Map<NewsCommentsDto>(comment);
            return CreateActionResult(CustomResponseDto<NewsCommentsDto>.Success(200, commentDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveComment(NewsCommentsDto commentDto)
        {
            await _newsCommentsService.AddAsync(_mapper.Map<NewsComments>(commentDto));
            return CreateActionResult(CustomResponseDto<NewsCommentsDto>.Success(201,commentDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(NewsCommentsDto commentDto)
        {
            await _newsCommentsService.Update(_mapper.Map<NewsComments>(commentDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _newsCommentsService.GetByIdAsync(id);
            await _newsCommentsService.Remove(comment);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
