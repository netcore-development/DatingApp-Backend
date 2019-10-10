using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DbContextSqlServer : DbContext
    {
        public DbContextSqlServer(DbContextOptions<DbContextSqlServer>options) : base(options) {}

        public DbSet<Value> Values{get;set;} 

    }
}