using MovieWebsite.Data;

using System.Collections.Generic;

namespace MovieWebsite.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public ICollection<Film> Films { get; set; }
    }
    public enum Role : byte
    {
        User,
        VIP,
        ADMIN
    }
}
