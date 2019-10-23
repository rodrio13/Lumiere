using System.Linq;
using Lumiere.Models.Interfaces;
using Lumiere.Models.Tables;

namespace Lumiere.Models.EFRepositorys
{
    public class UserLoginEFRepository : IUserLoginRepository
    {
        private LumiereDbContext context;
        public UserLoginEFRepository(LumiereDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<UserLoginTable> LoginTables => context.LoginTables;
    }
}