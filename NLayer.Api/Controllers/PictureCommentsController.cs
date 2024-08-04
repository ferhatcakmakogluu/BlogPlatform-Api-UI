using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class PictureCommentsController : CustomBaseController
    {
        private readonly IPictureCommentsService _pictureCommentsService;
        private readonly IMapper _mapper;

        public PictureCommentsController(IPictureCommentsService pictureCommentsService, IMapper mapper)
        {
            _pictureCommentsService = pictureCommentsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _pictureCommentsService.GetAllAsync();
            var commentsDto = _mapper.Map<List<PictureCommentsDto>>(comments);
            return CreateActionResult(CustomResponseDto<List<PictureCommentsDto>>.Success(200, commentsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var comment = await _pictureCommentsService.GetByIdAsync(id);
            var commentDto = _mapper.Map<PictureCommentsDto>(comment);
            return CreateActionResult(CustomResponseDto<PictureCommentsDto>.Success(200, commentDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveComment(PictureCommentsDto pictureCommentsDto)
        {
            await _pictureCommentsService.AddAsync(_mapper.Map<PictureComments>(pictureCommentsDto));
            return CreateActionResult(CustomResponseDto<PictureCommentsDto>.Success(201, pictureCommentsDto));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveRangeComment(List<PictureCommentsDto> pictureCommentsDto)
        {
            await _pictureCommentsService.AddRangeAsync(_mapper.Map<List<PictureComments>>(pictureCommentsDto));
            return CreateActionResult(CustomResponseDto<List<PictureCommentsDto>>.Success(201, pictureCommentsDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(PictureCommentsDto pictureCommentsDto)
        {
            await _pictureCommentsService.Update(_mapper.Map<PictureComments>(pictureCommentsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(PictureCommentsDto pictureCommentsDto)
        {
            await _pictureCommentsService.Remove(_mapper.Map<PictureComments>(pictureCommentsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMergeComment(List<PictureCommentsDto> pictureCommentsDto)
        {
            await _pictureCommentsService.RemoveMerge(_mapper.Map<List<PictureComments>>(pictureCommentsDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
