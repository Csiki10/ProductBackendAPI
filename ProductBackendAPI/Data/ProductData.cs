using ProductBackendAPI.Models;

namespace ProductBackendAPI.Data
{
    public static class ProductData
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        static ProductData()
        {
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Ball", Description = "Red ball", Price = 10m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Pen", Description = "Nice pec", Price = 20m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Laptop", Description = "Dell Inspiron", Price = 12m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Mobile phone", Description = "Iphone XR", Price = 34m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Monitor", Description = "LG ultra wide", Price = 21m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Book", Description = "DUNE", Price = 55m });
            Products.Add(new Product { Id = Guid.NewGuid().ToString(), Name = "Mouse", Description = "Wireless", Price = 72m });
        }
    }
}