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
    public class NewsCommentsSeed : IEntityTypeConfiguration<NewsComments>
    {
        public void Configure(EntityTypeBuilder<NewsComments> builder)
        {
            builder.HasData(
                new NewsComments
                {
                    Id = 1,
                    Comment = "Comment 1",
                    CommentedBy = "User 1",
                    CommentedDate = DateTime.Now,
                    NewsId = 1
                },
                new NewsComments
                {
                    Id = 2,
                    Comment = "Comment 2",
                    CommentedBy = "User 2",
                    CommentedDate = DateTime.Now,
                    NewsId = 1
                },
                new NewsComments
                {
                    Id = 3,
                    Comment = "Comment 3",
                    CommentedBy = "User 3",
                    CommentedDate = DateTime.Now,
                    NewsId = 2
                },
                new NewsComments
                {
                    Id = 4,
                    Comment = "Comment 4",
                    CommentedBy = "User 4",
                    CommentedDate = DateTime.Now,
                    NewsId = 3
                }
            );
        }
    }
}
