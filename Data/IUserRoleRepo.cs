using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace ValuesApi.Data
{
    public interface IUserRoleRepo
    {
        bool SaveChanges();
        IEnumerable<UserRole> GetAllUserRoles();
        UserRole GetUserRoleById(int id);
        UserRole GetUserRoleLast();
        void CreateUserRole(UserRole uRol);
        void UpdateUserRole(UserRole uRol);
    }
}
