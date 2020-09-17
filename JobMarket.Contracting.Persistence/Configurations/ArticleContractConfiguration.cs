using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Configurations
{
    public class ArticleContractConfiguration : IEntityTypeConfiguration<ArticleContract>
    {
        public void Configure(EntityTypeBuilder<ArticleContract> builder)
        {
            builder.Property(e => e.Data)
                .IsRequired(true);
        }
    }
}
