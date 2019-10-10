using DatingApp_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_Backend.Data
{
    public class DbContextPostgreSql : DbContext
    {
        public DbContextPostgreSql(DbContextOptions<DbContextPostgreSql>options) : base(options) {}
        public DbSet<Value> Values{get;set;}
        public DbSet<User> Users { get; set; }

        
    }
}