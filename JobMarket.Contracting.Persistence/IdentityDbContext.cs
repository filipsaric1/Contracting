using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobMarket.Contracting.Persistence
{
    public class IdentityDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<User>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleContract>()
                .HasKey(ac => new { ac.ArticleId, ac.ContractId });
            modelBuilder.Entity<ArticleContract>()
                .HasOne(ac => ac.Article)
                .WithMany(a => a.ArticleContracts)
                .HasForeignKey(ac => ac.ArticleId)
                .HasPrincipalKey(x => x.Id);
            modelBuilder.Entity<ArticleContract>()
                .HasOne(c => c.Contract)
                .WithMany(a => a.ArticleContracts)
                .HasForeignKey(c => c.ContractId)
                .HasPrincipalKey(x => x.Id);

            modelBuilder.Entity<TemplateClause>()
                .HasKey(tc => new { tc.TemplateId, tc.ClauseId });
            modelBuilder.Entity<TemplateClause>()
                .HasOne(tc => tc.Template)
                .WithMany(t => t.TemplateClauses)
                .HasForeignKey(tc => tc.TemplateId)
                .HasPrincipalKey(x => x.Id);
            modelBuilder.Entity<TemplateClause>()
                .HasOne(c => c.Clause)
                .WithMany(a => a.TemplateClauses)
                .HasForeignKey(ac => ac.ClauseId)
                .HasPrincipalKey(x => x.Id);
            modelBuilder.Entity<Template>()
                .HasMany(t => t.Contracts)
                .WithOne(c => c.Template)
                .IsRequired();
            modelBuilder.Entity<Clause>()
                .HasMany(c => c.Articles)
                .WithOne(a => a.Clause)
                .IsRequired();
            modelBuilder.Entity<Article>()
                .HasMany(a => a.Placeholders)
                .WithOne(p => p.Article)
                .IsRequired();
            modelBuilder.Entity<Article>()
                .HasOne(a => a.Clause)
                .WithMany(c => c.Articles)
                .HasForeignKey(x => x.ClauseId);
            modelBuilder.Entity<Contract>()
                .HasOne(c => c.Template)
                .WithMany(t => t.Contracts)
                .HasForeignKey(x => x.TemplateId);
            
           
        }

    }
}
