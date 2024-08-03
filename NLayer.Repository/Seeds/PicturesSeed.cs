using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class PicturesSeed : IEntityTypeConfiguration<Pictures>
    {
        public void Configure(EntityTypeBuilder<Pictures> builder)
        {
            builder.HasData(
                new Pictures
                {
                    Id = 1,
                    PictureUrl = "/Pictures/1",
                    AlbumeId = 1
                },
                new Pictures
                {
                    Id = 2,
                    PictureUrl = "/Pictures/2",
                    AlbumeId = 1
                },
                new Pictures
                {
                    Id = 3,
                    PictureUrl = "/Pictures/3",
                    AlbumeId = 2
                },
                new Pictures
                {
                    Id = 4,
                    PictureUrl = "/Pictures/4",
                    AlbumeId = 3
                }
            );
        }
    }
}
