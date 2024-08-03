using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class Pictures
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public int? PictureLike {  get; set; }
        public int? PictureDislike { get; set; }
        public int AlbumeId { get; set; }
        public Albume Albume { get; set; }
        public List<PictureComments> PictureComments { get; set; }
    }
}
