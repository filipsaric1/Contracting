using Microsoft.AspNetCore.Identity;

namespace JobMarket.Contracting.Domain.Entities
{
    public enum Role
    {
        ADMINISTRATOR,
        EXECUTOR,
        CLIENT
    }
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

    }

}
