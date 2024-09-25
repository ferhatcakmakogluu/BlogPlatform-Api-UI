using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class AdminApiService
    {
        private readonly HttpClient _httpClient;

        public AdminApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AdminsDto> LoginAdmin(string username, string pass)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<AdminsDto>>>("Admins");
            var res = response.Data.Where(x => x.UserName == username && x.Password == pass).FirstOrDefault();
            return res;
        }
    }
}
