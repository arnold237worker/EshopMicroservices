namespace Catalog.API.Data
{
    public class CatalogInitalData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            using var session = store.LightweightSession();

            if (await session.Query<Product>().AnyAsync())
                return;

            session.Store<Product>(GetPreconfiguredProducts());
            await session.SaveChangesAsync(cancellation);
        }

        private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "IPhone X",
                Description = "This phone is the company's biggest change",
                ImageFile = "product-1.png",
                Price = 950,
                Category = new List<string>{ "Smart Phone" }
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "IPhone XR",
                Description = "This phone is the company's biggest change",
                ImageFile = "product-2.png",
                Price = 970,
                Category = new List<string>{ "Smart Phone" }
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "IPhone 11",
                Description = "This phone is the company's biggest change",
                ImageFile = "product-3.png",
                Price = 1000,
                Category = new List<string>{ "Smart Phone" }
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "IPhone 11 PRO",
                Description = "This phone is the company's biggest change",
                ImageFile = "product-4.png",
                Price = 1100,
                Category = new List<string>{ "Smart Phone" }
            }
        };
    }
}
