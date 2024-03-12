using ProductBackendAPI.Models;

namespace ProductBackendAPI.Data
{
    public static class ProductData
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        static ProductData()
        {
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description 1", Price = 10.99m });
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description 2", Price = 20.99m });
        }
    }
}