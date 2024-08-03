using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class Albume
    {
        public int Id { get; set; }
        public string AlbumeName { get; set; }
        public string? Description { get; set; }
        public string? CoverPhoto {  get; set; }
        public int? AlbumeLike {  get; set; }
        public int? AlbumeDislike { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    
        public int PicturesId { get; set; }
        public List<Pictures> Pictures { get; set; }
    }
}
