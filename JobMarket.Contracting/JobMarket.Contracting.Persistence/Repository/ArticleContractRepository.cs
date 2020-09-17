using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class ArticleContractRepository : BaseRepository<ArticleContract>
    {
        public ArticleContractRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
