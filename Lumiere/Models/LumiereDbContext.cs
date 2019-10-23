using Microsoft.EntityFrameworkCore;
using Lumiere.Models.Tables;

namespace Lumiere.Models
{
    public class LumiereDbContext : DbContext
    {
        public LumiereDbContext(DbContextOptions<LumiereDbContext> options) : base(options)
        {

        }
        public DbSet<UserLoginTable> LoginTables { get; set; }
    }
}