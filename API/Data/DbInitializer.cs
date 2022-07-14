using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Angular Speedster Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    Brand = "Angular",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-ang1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Angular Board 3000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 19999,
                    Brand = "Angular",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-ang2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Board Speed Rush 3",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    Brand = "Redis",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-core1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Net Core Super Board",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 16999,
                    Brand = "NetCore",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-core2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "React Board Super Whizzy Fast",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 17000,
                    Brand = "React",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-react1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Typescript Entry Board",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 13000,
                    Brand = "typescript",
                    Type = "Boards",
                    PictureUrl = "images/products/sb-ts1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Blue Hat",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 13000,
                    Brand = "NetCore",
                    Type = "Hat",
                    PictureUrl = "images/products/hat-core1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Woolen Hat",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 9000,
                    Brand = "React",
                    Type = "Hat",
                    PictureUrl = "images/products/hat-react1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Woolen Hat",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    Brand = "React",
                    Type = "Hat",
                    PictureUrl = "images/products/hat-react2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14000,
                    Brand = "VS Code",
                    Type = "Gloves",
                    PictureUrl = "images/products/glove-code1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Code Gloves",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14000,
                    Brand = "VS Code",
                    Type = "Gloves",
                    PictureUrl = "images/products/glove-code2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Gloves",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    Brand = "VS Code",
                    Type = "Gloves",
                    PictureUrl = "images/products/glove-react1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Gloves",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    Brand = "VS Code",
                    Type = "Gloves",
                    PictureUrl = "images/products/glove-react2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Redis Red Boots",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12999,
                    Brand = "Redis",
                    Type = "Boots",
                    PictureUrl = "images/products/boot-redis1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Red Boots",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 9000,
                    Brand = "NetCore",
                    Type = "Boots",
                    PictureUrl = "images/products/boot-core2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Purple Boots",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 4000,
                    Brand = "NetCore",
                    Type = "Boots",
                    PictureUrl = "images/products/boot-core1.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Purple Boots",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 6000,
                    Brand = "Angular",
                    Type = "Boots",
                    PictureUrl = "images/products/boot-ang2.png",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Blue Boots",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10000,
                    Brand = "Angular",
                    Type = "Boots",
                    PictureUrl = "images/products/boot-ang1.png",
                    QuantityInStock = 100
                },

            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}