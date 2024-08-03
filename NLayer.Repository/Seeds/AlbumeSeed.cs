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
    public class AlbumeSeed : IEntityTypeConfiguration<Albume>
    {
        public void Configure(EntityTypeBuilder<Albume> builder)
        {
            builder.HasData(
                new Albume
                {
                    Id = 1,
                    AlbumeName = "Albume 1",
                    CreatedDate = DateTime.Now
                },
                new Albume
                {
                    Id = 2,
                    AlbumeName = "Albume 2",
                    CreatedDate = DateTime.Now
                },
                new Albume
                {
                    Id = 3,
                    AlbumeName = "Albume 3",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
