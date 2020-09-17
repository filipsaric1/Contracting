using Microsoft.AspNetCore.Identity;

namespace JobMarket.Contracting.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
