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
    public class NewsSeed : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(
                new News
                {
                    Id = 1,
                    Title = "News 1",
                    Description = "Description 1",
                    CreatedDate = DateTime.Now,
                    IsPinned = false
                },
                new News
                {
                    Id = 2,
                    Title = "News 2",
                    Description = "Description 2",
                    CreatedDate = DateTime.Now,
                    IsPinned = false
                },
                new News
                {
                    Id = 3,
                    Title = "News 3",
                    Description = "Description 3",
                    CreatedDate = DateTime.Now,
                    IsPinned = false
                }
            );
        }
    }
}
