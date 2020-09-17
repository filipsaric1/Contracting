using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class ClauseRepository : BaseRepository<Clause>
    {
        public ClauseRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
