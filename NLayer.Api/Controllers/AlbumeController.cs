using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class AlbumeController : CustomBaseController
    {
        private readonly IAlbumeService _albumeService;
        private readonly IMapper _mapper;

        public AlbumeController(IAlbumeService albumeService, IMapper mapper)
        {
            _albumeService = albumeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAlbume()
        {
            var albumes = await _albumeService.GetAllAsync();
            var albumesDto = _mapper.Map<List<AlbumeDto>>(albumes);
            return CreateActionResult(CustomResponseDto<List<AlbumeDto>>.Success(200, albumesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbumById(int id)
        {
            var albume = await _albumeService.GetByIdAsync(id);
            var albumeDto = _mapper.Map<AlbumeDto>(albume);
            return CreateActionResult(CustomResponseDto<AlbumeDto>.Success(200, albumeDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveAlbume(AlbumeDto albumeDto)
        {
            await _albumeService.AddAsync(_mapper.Map<Albume>(albumeDto));
            return CreateActionResult(CustomResponseDto<AlbumeDto>.Success(201, albumeDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAlbume(AlbumeDto albumeDto)
        {
            await _albumeService.Update(_mapper.Map<Albume>(albumeDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAlbume(int id)
        {
            var albume = await _albumeService.GetByIdAsync(id);
            await _albumeService.Remove(albume);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
