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
    public class PictureCommentsSeed : IEntityTypeConfiguration<PictureComments>
    {
        public void Configure(EntityTypeBuilder<PictureComments> builder)
        {
            builder.HasData(
                new PictureComments
                {
                    Id = 1,
                    Comment = "Comment 1",
                    CommentedBy = "User 1",
                    CommentedDate = DateTime.Now,
                    PicturesId = 1
                },
                new PictureComments
                {
                    Id = 2,
                    Comment = "Comment 2",
                    CommentedBy = "User 2",
                    CommentedDate = DateTime.Now,
                    PicturesId = 1
                },
                new PictureComments
                {
                    Id = 3,
                    Comment = "Comment 3",
                    CommentedBy = "User 3",
                    CommentedDate = DateTime.Now,
                    PicturesId = 2
                },
                new PictureComments
                {
                    Id = 4,
                    Comment = "Comment 4",
                    CommentedBy = "User 4",
                    CommentedDate = DateTime.Now,
                    PicturesId = 3
                }
            );
        }
    }
}
