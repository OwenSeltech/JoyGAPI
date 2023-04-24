using Microsoft.AspNetCore.Identity;

namespace JoyGAPI.Entities
{
    public class Roles : IdentityRole<int>
    {
        public ICollection<UserRoles> UserRoles { get; set; }

    }
}
