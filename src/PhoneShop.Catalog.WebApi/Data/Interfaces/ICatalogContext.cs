using MongoDB.Driver;
using PhoneShop.Catalog.WebApi.Entities;

namespace PhoneShop.Catalog.WebApi.Data.Interfaces;

public interface ICatalogContext
{
    IMongoCollection<Product> Propducts { get; }
}
