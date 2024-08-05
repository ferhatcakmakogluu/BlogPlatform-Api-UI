using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class NewsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ReadCount { get; set; } = 0;
        public int? LikeCount { get; set; } = 0;
        public int? DislikeCount { get; set; } = 0;
        public bool? IsPinned { get; set; } = false;
    }
}
