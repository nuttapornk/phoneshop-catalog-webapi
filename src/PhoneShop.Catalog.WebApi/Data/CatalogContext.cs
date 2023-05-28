using MongoDB.Driver;
using PhoneShop.Catalog.WebApi.Data.Interfaces;
using PhoneShop.Catalog.WebApi.Entities;

namespace PhoneShop.Catalog.WebApi.Data;

public class CatalogContext : ICatalogContext
{
    public CatalogContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
        var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

        Propducts = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
        CatalogContextSeed.SeedData(Propducts);
    }

    public IMongoCollection<Product> Propducts { get; }
}
