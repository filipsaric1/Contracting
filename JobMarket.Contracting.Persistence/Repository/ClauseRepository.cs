using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class ClauseRepository : BaseRepository<Clause>
    {
        public ClauseRepository(IdentityDbContext dbContext) : base(dbContext)
        {
            
        }
        public Clause ClauseDetails(int id)
        {
            return this.DbSet.Include(c => c.Articles).Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
