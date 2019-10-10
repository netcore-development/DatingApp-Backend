using DatingApp_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_Backend.Data
{
    public class DbContextSqlite : DbContext
    {
        public DbContextSqlite(DbContextOptions<DbContextSqlite>options) : base(options){}
        public DbSet<Value> Values{get;set;} 

    }
}