using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    public class AdminsController : CustomBaseController
    {
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AdminsController(IAdminService adminService, IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var admins = await _adminService.GetAllAsync();
            var adminsDto = _mapper.Map<List<AdminsDto>>(admins);
            return CreateActionResult(CustomResponseDto<List<AdminsDto>>.Success(200,adminsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var admin = await _adminService.GetByIdAsync(id);
            var adminDto = _mapper.Map<AdminsDto>(admin);
            return CreateActionResult(CustomResponseDto<AdminsDto>.Success(200,adminDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveAdmin(AdminsDto adminDto)
        {
            await _adminService.AddAsync(_mapper.Map<Admins>(adminDto));
            return CreateActionResult(CustomResponseDto<AdminsDto>.Success(201,adminDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdmin(AdminsDto adminDto)
        {
            await _adminService.Update(_mapper.Map<Admins>(adminDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAdmin(int id)
        {
            var admin = await _adminService.GetByIdAsync(id);
            var response = _adminService.Remove(admin);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
