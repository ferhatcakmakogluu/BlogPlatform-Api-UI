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
    public class PictureCommentsConfiguration : IEntityTypeConfiguration<PictureComments>
    {
        public void Configure(EntityTypeBuilder<PictureComments> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Comment).IsRequired().HasMaxLength(500);
            builder.Property(x => x.CommentedBy).IsRequired().HasMaxLength(250);
        }
    }
}
