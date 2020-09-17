using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class TemplateClauseRepository : BaseRepository<TemplateClause>
    {
        public TemplateClauseRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
