using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.EntityConfigurations
{
    public class AlbumeConfiguration : IEntityTypeConfiguration<Albume>
    {
        public void Configure(EntityTypeBuilder<Albume> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.AlbumeName).IsRequired().HasMaxLength(250);
        }
    }
}
