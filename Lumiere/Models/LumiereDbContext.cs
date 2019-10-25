using Microsoft.EntityFrameworkCore;
using Lumiere.Models.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Lumiere.Models
{
    public class LumiereDbContext : IdentityDbContext<UserTable>
    {
        public LumiereDbContext(DbContextOptions<LumiereDbContext> options) : base(options)
        {

        }
        public DbSet<UserTable> UserTables { get; set; }
    }
}