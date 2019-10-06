using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DbContextSqlite : DbContext
    {
        public DbContextSqlite(DbContextOptions<DbContextSqlite>options) : base(options){}
        public DbSet<Value> Values{get;set;} 
        public DbSet<Person> Persons{get;set;}
    }
}