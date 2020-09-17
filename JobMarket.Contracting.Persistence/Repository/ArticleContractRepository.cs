using JobMarket.Contracting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class ArticleContractRepository : BaseRepository<ArticleContract>
    {
        public ArticleContractRepository(IdentityDbContext dbContext) : base(dbContext)
        {
            
        }
        //public void Update(ArticleContract updatedArticleContract)
        //{
        //    var articleContract = this.Single(updatedArticleContract.Id);
        //    Db.Entry(articleContract).CurrentValues.SetValues(updatedArticleContract);
        //}
        /*public List<ArticleContract> GetByContractId(int id)
        {
            var articleContract = Db.
        }
        */
    }
}
