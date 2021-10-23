using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace ValuesApi.Data
{
    interface IUserRepo
    {
        bool SaveChanges();
        IEnumerable<dynamic> GetUsers();
        User GetUserById(int id);
        User GetUserLast();
        void CreateUser(User user);
        void UpdateUser(User user);
    }
}
