﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class PictureComments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CommentedDate { get; set; }
    
        public int PicturesId { get; set; }
        public Pictures Pictures { get; set; }
    }
}
