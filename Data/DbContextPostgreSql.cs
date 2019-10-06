using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DbContextPostgreSql : DbContext
    {
        public DbContextPostgreSql(DbContextOptions<DbContextPostgreSql>options) : base(options) {}
        public DbSet<Value> Values{get;set;}
        public DbSet<Person> Persons{get;set;} 

        
    }
}