﻿using MongoRepo.Context;

namespace Catalog.API.Context
{
    public class CatalogDbContext : ApplicationDbContext
    {
        static IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        static string connectionString = configuration.GetConnectionString("Catalog.API");
        static string databaseName = configuration.GetValue<string>("DatabaseName");
        public CatalogDbContext(string connectionString, string databaseName) : base(connectionString, databaseName)
        {
        }
    }
}
