using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class AlbumeWithPicturesAndCommentsDto : AlbumeDto
    {
        public List<Pictures> Pictures { get; set; }
        public List<PictureCommentsDto> PictureComments { get; set; }
    }
}
