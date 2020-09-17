using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.Now);
            builder.Property(e => e.IsSignedByClient)
                .HasDefaultValue(false);
            builder.Property(e => e.IsSignedByExecutor)
                .HasDefaultValue(false);
            builder.Property(e => e.State)
                .HasDefaultValue(ContractState.UnSigned);
            builder.Property(e => e.SignedAt)
                .IsRequired(false);
            
            builder.Property(e => e.AnnexId)
                .IsRequired(false);
        }
    }
}
