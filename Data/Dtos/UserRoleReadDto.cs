using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace Commander.Dtos
{
    public class UserRoleReadDto
    {
        public int UserRoleId { get; set; }
        public string Name { get; set; }
        public ICollection<User> User { get; set; }
    }
}
