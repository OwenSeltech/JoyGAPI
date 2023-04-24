using Microsoft.AspNetCore.Identity;

namespace JoyGAPI.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public bool IsEmployed { get; set; } = false;
        public ICollection<UserRoles> UserRoles { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
