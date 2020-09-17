using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class ContractRepository : BaseRepository<Contract>
    {
        public ContractRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }

    }
}
