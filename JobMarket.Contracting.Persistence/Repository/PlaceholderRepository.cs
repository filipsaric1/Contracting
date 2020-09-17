using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
   public class PlaceholderRepository : BaseRepository<Placeholder>
    {
        public PlaceholderRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
