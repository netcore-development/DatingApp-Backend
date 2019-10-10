using DatingApp_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_Backend.Data
{
    public class DbContextSqlServer : DbContext
    {
        public DbContextSqlServer(DbContextOptions<DbContextSqlServer>options) : base(options) {}

        public DbSet<Value> Values{get;set;} 

    }
}