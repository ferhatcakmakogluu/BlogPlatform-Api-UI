﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class PictureWithCommentsDto : PicturesDto
    {
        public List<PictureCommentsDto> PictureComments { get; set; }
    }
}
