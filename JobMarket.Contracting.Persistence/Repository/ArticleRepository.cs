using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Article> GetArticleDetails(int id)
        {
            return await DbSet.Include(a => a.Placeholders).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
