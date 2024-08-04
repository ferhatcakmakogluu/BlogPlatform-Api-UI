using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Admins,AdminsDto>().ReverseMap();
            CreateMap<Albume,AlbumeDto>().ReverseMap();
            CreateMap<News,NewsDto>().ReverseMap();
            CreateMap<NewsComments,NewsCommentsDto>().ReverseMap();
            CreateMap<Pictures,PicturesDto>().ReverseMap();
            CreateMap<PictureComments,PictureCommentsDto>().ReverseMap();
        }
    }
}
