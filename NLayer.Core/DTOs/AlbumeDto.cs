using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class AlbumeDto
    {
        public int Id { get; set; }
        public string AlbumeName { get; set; }
        public string? Description { get; set; }
        public string? CoverPhoto { get; set; }
        public int? AlbumeLike { get; set; }
        public int? AlbumeDislike { get; set; }
    }
}
