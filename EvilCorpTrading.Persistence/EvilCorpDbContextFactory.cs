using EvilCorpTrading.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EvilCorpTrading.Persistence
{
    public class EvilCorpDbContextFactory : DesignTimeDbContextFactoryBase<EvilCorpDbContext>
    {
        protected override EvilCorpDbContext CreateNewInstance(DbContextOptions<EvilCorpDbContext> options)
        {
            return new EvilCorpDbContext(options);
        }
    }
}
