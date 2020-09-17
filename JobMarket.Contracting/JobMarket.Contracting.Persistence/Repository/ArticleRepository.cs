using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
