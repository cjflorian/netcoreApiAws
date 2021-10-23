using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuesApi.Models;

namespace ValuesApi.Data
{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
