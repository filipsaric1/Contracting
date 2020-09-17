using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace JobMarket.Contracting.Persistence.Configurations
{
    class ClauseConfiguration : IEntityTypeConfiguration<Clause>
    {
        public void Configure(EntityTypeBuilder<Clause> builder)
        {
            builder.Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(60); ;
        }

    }
}