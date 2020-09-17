using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Configurations
{
    public class PlaceholderConfiguration : IEntityTypeConfiguration<Placeholder>
    {
        public void Configure(EntityTypeBuilder<Placeholder> builder)
        {
            builder.Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(60);
            builder.Property(e => e.Location)
                .IsRequired(true)
                .HasMaxLength(20);
        }
    }
}
