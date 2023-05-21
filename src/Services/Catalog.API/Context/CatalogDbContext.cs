using MongoRepo.Context;

namespace Catalog.API.Context
{
    public class CatalogDbContext : ApplicationDbContext
    {
        static IConfiguration configuration = new ConfigurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();

        public CatalogDbContext(string connectionString, string databaseName) : base(connectionString, databaseName)
        {

        }
    }
}
