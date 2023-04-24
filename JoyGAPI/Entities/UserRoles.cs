using Microsoft.AspNetCore.Identity;

namespace JoyGAPI.Entities
{
    public class UserRoles : IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public Roles Role { get; set; }
    }
}
