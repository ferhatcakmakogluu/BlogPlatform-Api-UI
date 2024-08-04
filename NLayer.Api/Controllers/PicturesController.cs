using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class PicturesController : CustomBaseController
    {
        private readonly IPicturesService _picturesService;
        private readonly IMapper _mapper;

        public PicturesController(IPicturesService picturesService, IMapper mapper)
        {
            _picturesService = picturesService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPictures()
        {
            var pictures = await _picturesService.GetAllAsync();
            var picturesDto = _mapper.Map<List<PicturesDto>>(pictures);
            return CreateActionResult(CustomResponseDto<List<PicturesDto>>.Success(200, picturesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPictureById(int id)
        {
            var picture = await _picturesService.GetByIdAsync(id);
            var pictureDto = _mapper.Map<PicturesDto>(picture);
            return CreateActionResult(CustomResponseDto<PicturesDto>.Success(200, pictureDto));
        }

        [HttpPost]
        public async Task<IActionResult> SavePicture(PicturesDto pictureDto)
        {
            await _picturesService.AddAsync(_mapper.Map<Pictures>(pictureDto));
            return CreateActionResult(CustomResponseDto<PicturesDto>.Success(201, pictureDto));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveRangePictures(List<PicturesDto> picturesDtos)
        {
            await _picturesService.AddRangeAsync(_mapper.Map<List<Pictures>>(picturesDtos));
            return CreateActionResult(CustomResponseDto<List<PicturesDto>>.Success(201, picturesDtos));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePicture(PicturesDto pictureDto)
        {
            await _picturesService.Update(_mapper.Map<Pictures>(pictureDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePicture(int id)
        {
            var picture = await _picturesService.GetByIdAsync(id);
            await _picturesService.Remove(picture);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
