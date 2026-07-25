using Microsoft.EntityFrameworkCore;

namespace MySecondWebApi.Models;
//using Microsoft.EntityFrameworkCore;


    public static class ModelBuilderExtensions
    {
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Active Wear - Men" },
            new Category { Id = 2, Name = "Active Wear - Women" }, 
            new Category { Id = 3, Name = "Mineral Water" },
            new Category { Id = 4, Name = "Publications" },
            new Category { Id = 5, Name = "Supplements" });

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, CategoryId = 1, Name = "Grunge Skater Jeans", SKU = "AWMGSJ", Price = 68, IsAvailable = false },
            new Product { Id = 2, CategoryId = 1, Name = "Polo Shirt", SKU = "AWMPS", Price = 35, IsAvailable = false },
            new Product { Id = 3, CategoryId = 1, Name = "Skater Graphic T-Shirt", SKU = "AWMSGT", Price = 33, IsAvailable = true },
            new Product { Id = 4, CategoryId = 1, Name = "Slicker Jacket", SKU = "AWMSJ", Price = 125, IsAvailable = true },
            new Product { Id = 5, CategoryId = 1, Name = "Thermal Fleece Jacket", SKU   = "AWMTFJ", Price = 60, IsAvailable = true },
            new Product { Id = 6, CategoryId = 1, Name = "Unisex Thermal Vest", SKU = "AWMUTV", Price = 95, IsAvailable = true },
            new Product { Id = 7, CategoryId = 1, Name = "V-Neck Pullover", SKU = "AWMVNP", Price = 65, IsAvailable = true },
            new Product { Id = 8, CategoryId = 1, Name = "V-Neck Sweater", SKU = "AWMVNS", Price = 65, IsAvailable = true },
            new Product { Id = 9, CategoryId = 1, Name = "V-Neck T-Shirt", SKU = "AWMVNT", Price = 17, IsAvailable = true },
            new Product { Id = 10, CategoryId = 2, Name = "Bamboo Thermal Ski Coat", SKU = "AWWBTSC", Price = 99, IsAvailable = true },
            new Product { Id = 11, CategoryId = 2, Name = "Cross-Back Training Tank", SKU = "AWWCTT", Price = 0, IsAvailable = false },
            new Product { Id = 12, CategoryId = 2, Name = "Grunge Skater Jeans", SKU = "AWWGSJ", Price = 68, IsAvailable = true },
            new Product { Id = 13, CategoryId = 2, Name = "Slicker Jacket", SKU = "AWWSJ", Price = 125, IsAvailable = true },
            new Product { Id = 14, CategoryId = 2, Name = "Stretchy Dance Pants", SKU = "AWWSDP", Price = 55, IsAvailable = true },
            new Product { Id = 15, CategoryId = 2, Name = "Ultra-Soft Tank Top", SKU = "AWWUTT", Price = 22, IsAvailable = true },
            new Product { Id = 16, CategoryId = 2, Name = "Unisex Thermal Vest", SKU = "AWWUTV", Price = 95, IsAvailable = true },
            new Product { Id = 17, CategoryId = 2, Name = "V-Next T-Shirt", SKU = "AWWVNT", Price = 17, IsAvailable = true },
            new Product { Id = 18, CategoryId = 3, Name = "Blueberry Mineral Water", SKU = "MWB", Price = 2.8M, IsAvailable = true },
            new Product { Id = 19, CategoryId = 3, Name = "Lemon-Lime Mineral Water", SKU = "MWLL", Price = 2.8M, IsAvailable = true },
            new Product { Id = 20, CategoryId = 3, Name = "Orange Mineral Water", SKU = "MWO", Price = 2.8M, IsAvailable = true },
            new Product { Id = 21, CategoryId = 3, Name = "Peach Mineral Water", SKU = "MWP", Price = 2.8M, IsAvailable = true },
            new Product { Id = 22, CategoryId = 3, Name = "Raspberry Mineral Water", SKU = "MWR", Price = 2.8M, IsAvailable = true },
            new Product { Id = 23, CategoryId = 3, Name = "Strawberry Mineral Water", SKU = "MWS", Price = 2.8M, IsAvailable = true },
            new Product { Id = 24, CategoryId = 4, Name = "In the Kitchen with H+ Sport", SKU = "PITK", Price = 24.99M, IsAvailable = true },
            new Product { Id = 25, CategoryId = 5, Name = "Calcium 400 IU (150 tablets)", SKU = "SC400", Price = 9.99M, IsAvailable = true },
            new Product { Id = 26, CategoryId = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", SKU = "SFO100", Price = 12.49M, IsAvailable = true },
            new Product { Id = 27, CategoryId = 5, Name = "Iron 65 mg (150 caplets)", SKU = "SI65", Price = 13.99M, IsAvailable = true },
            new Product { Id = 28, CategoryId = 5, Name = "Magnesium 250 mg (100 tablets)", SKU = "SM250", Price = 12.49M, IsAvailable = true },
            new Product { Id = 29, CategoryId = 5, Name = "Multi-Vitamin (90 capsules)", SKU = "SMV", Price = 9.99M, IsAvailable = true },
            new Product { Id = 30, CategoryId = 5, Name = "Vitamin A 10,000 IU (125 caplets)", SKU = "SVA", Price = 11.99M, IsAvailable = true },
            new Product { Id = 31, CategoryId = 5, Name = "Vitamin B-Complex (100 caplets)", SKU = "SVB", Price = 12.99M, IsAvailable = true },
            new Product { Id = 32, CategoryId = 5, Name = "Vitamin C 1000 mg (100 tablets)", SKU = "SVC", Price = 9.99M, IsAvailable = true },
            new Product { Id = 33, CategoryId = 5, Name = "Vitamin D3 1000 IU (100 tablets)", SKU = "SVD3", Price = 12.49M, IsAvailable = false });
    }
}
