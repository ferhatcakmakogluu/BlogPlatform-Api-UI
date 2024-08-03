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
    public class AdminSeed : IEntityTypeConfiguration<Admins>
    {
        public void Configure(EntityTypeBuilder<Admins> builder)
        {
            builder.HasData(
                new Admins
                {
                    Id = 1,
                    Name = "Admin",
                    LastName = "Admin",
                    UserName = "root",
                    Password = "root123",
                    Role = "ADMIN"
                }
            );
        }
    }
}
