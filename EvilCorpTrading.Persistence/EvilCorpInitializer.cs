namespace EvilCorpTrading.Persistence
{
    public class EvilCorpInitializer
    {
        public static void Initialize(EvilCorpDbContext context)
        {
            var initializer = new EvilCorpInitializer();
            initializer.SeedEverything(context);
        }

        private void SeedEverything(EvilCorpDbContext context)
        {
            context.Database.EnsureCreated();

            //if (context.Customers.Any())
            //{
            //    return; // Db has been seeded
            //}
        }
    }
}
