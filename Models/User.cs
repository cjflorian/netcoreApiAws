using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValuesApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int UserRoleId { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
