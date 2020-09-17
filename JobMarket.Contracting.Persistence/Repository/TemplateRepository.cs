using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class TemplateRepository : BaseRepository<Template>
    {
        public TemplateRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
        public Template TemplateDetails(int id)
        {
            return this.DbSet.Include(t => t.TemplateClauses).ThenInclude(tc => tc.Clause).ThenInclude(c => c.Articles).Where(t => t.Id == id).FirstOrDefault();
        }
    }
}
