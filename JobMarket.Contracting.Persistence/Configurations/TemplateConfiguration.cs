using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Configurations
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            builder.Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(60);
            


        }
    }
}
