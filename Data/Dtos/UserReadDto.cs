
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace Commander.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserRoleId { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
