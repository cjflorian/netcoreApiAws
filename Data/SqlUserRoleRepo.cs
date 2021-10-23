using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace ValuesApi.Data
{
    public class SqlUserRoleRepo : IUserRoleRepo
    {
        private readonly DataContext _context;

        public SqlUserRoleRepo(DataContext context)
        {
            _context = context;
        }

        
        public void CreateUserRole(UserRole uRol)
        {
            try
            {
                if (uRol == null)
                    throw new ArgumentException(nameof(uRol));
                else
                {
                    _context.UserRoles.Add(uRol);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var msj = ex.Message;
            }
        }

        public IEnumerable<UserRole> GetAllUserRoles()
        {
            return _context.UserRoles.ToList();
        }


        public UserRole GetUserRoleById(int id)
        {
            return _context.UserRoles.FirstOrDefault(p => p.Id == id);
        }

        public UserRole GetUserRoleLast()
        {
            return _context.UserRoles.OrderByDescending(p => p.Id).FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }



        public void UpdateUserRole(UserRole uRol)
        {
            try
            {
                if (uRol == null)
                    throw new ArgumentException(nameof(uRol));
                else
                {
                    _context.UserRoles.Update(uRol);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var msj = ex.Message;
            }
        }

    }
}
