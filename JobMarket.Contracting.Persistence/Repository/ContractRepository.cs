using JobMarket.Contracting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class ContractRepository : BaseRepository<Contract>
    {

        public ContractRepository(IdentityDbContext dbContext) : base(dbContext)
        {

        }
        public void Update(Contract updatedContract)
        {
            var contract = ContractDetails(updatedContract.Id);
            var articles = new HashSet<ArticleContract>();

            foreach (var item in updatedContract.ArticleContracts)
            {
                articles.Add(new ArticleContract
                {
                    ArticleId = item.ArticleId,
                    ContractId = item.ContractId,
                    Data = item.Data
                });
            }
            Db.Entry(contract).CurrentValues.SetValues(updatedContract);
            contract.ArticleContracts = articles;

            ///await Db.SaveChangesAsync();
        }
        public Contract ContractDetails(int id)
        {
            return DbSet
                .Include(c => c.Annex)
                .Include(c => c.Template)
                    .ThenInclude(t => t.TemplateClauses)
                        .ThenInclude(tc => tc.Clause)
                            .ThenInclude(c => c.Articles)
                                .ThenInclude(a => a.Placeholders)
                .Include(c => c.ArticleContracts)
                    .ThenInclude(ac => ac.Article)
                        .ThenInclude(a => a.Placeholders)
                .FirstOrDefault(c => c.Id == id);
                
        }

    }
}
