using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntitiy>
    {
        public void Configure(EntityTypeBuilder<UserEntitiy> builder)
        {
            builder.ToTable("User");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.name).IsRequired().HasMaxLength(60);
            builder.HasIndex(p => p.email).IsUnique();
            builder.Property(p => p.email).HasMaxLength(100);
        }
    }
}
