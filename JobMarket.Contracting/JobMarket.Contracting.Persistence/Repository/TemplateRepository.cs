using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class TemplateRepository : BaseRepository<Template>
    {
        public TemplateRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
