using JobMarket.Contracting.Domain.Entities;

namespace JobMarket.Contracting.Persistence.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
