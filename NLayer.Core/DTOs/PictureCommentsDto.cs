using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class PictureCommentsDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string CommentedBy { get; set; }
        public int PicturesId { get; set; }
    }
}
