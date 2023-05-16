using System.ComponentModel.DataAnnotations;

namespace AnimalApp.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public DateTime AccountCreated { get; set; }
        public DateTime LastVisit { get; set; }
    }
}
