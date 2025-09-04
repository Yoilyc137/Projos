namespace BlazingPizza.Data;

internal static class SeedData
{
    internal static Task InitializeAsync(PizzaStoreContext db)
    {
        PizzaSpecial[] specials =
        [
            new()
            {
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
                Type = "Meat Lovers"
            },
            new()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
                Type = "Meat Lovers"
            },
            new()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
                Type = "Spicy"
            },
            new()
            {
                Id = 4,
                Name = "Buffalo chicken",
                Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
                Type = "Meat Lovers"
            },
            new()
            {
                Id = 5,
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
                Type = "Vegetarian"
            },
            new()
            {
                Id = 7,
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
                Type = "Vegetarian"
            },
            new()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
                Type = "Vegetarian"
            },
            new()
            {
                Id = 9,
                Name = "Margherita Family Size",
                Description = "24\" of pure tomatoes and basil",
                BasePrice = 14.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
                FixedSize = 24
            },
            new()
            {
                Id = 10,
                Name ="Classic Italian",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
                Type = "Vegetarian"
            },
            
            // New pizzas added below
            new()
            {
                Id = 11,
                Name = "The Supreme",
                Description = "A classic with pepperoni, sausage, peppers, and onions.",
                BasePrice = 14.50m,
                ImageUrl = "img/pizzas/supreme.jpg",
                Type = "Meat Lovers"
            },
            new()
            {
                Id = 12,
                Name = "Hawaiian",
                Description = "Sweet and savory with pineapple and ham.",
                BasePrice = 13.00m,
                ImageUrl = "img/pizzas/hawaiian.jpg",
                Type = "Fruit-based"
            },
            new()
            {
                Id = 13,
                Name = "BBQ Chicken",
                Description = "Grilled chicken, smoky BBQ sauce, and red onions.",
                BasePrice = 13.75m,
                ImageUrl = "img/pizzas/bbqchicken.jpg",
                Type = "Meat Lovers"
            },
            new()
            {
                Id = 14,
                Name = "Four-Cheese",
                Description = "A delicious blend of mozzarella, provolone, parmesan, and romano.",
                BasePrice = 12.00m,
                ImageUrl = "img/pizzas/fourcheese.jpg",
                Type = "Vegetarian"
            },
            new()
            {
                Id = 15,
                Name = "The Works",
                Description = "Everything you could possibly want on a pizza.",
                BasePrice = 16.00m,
                ImageUrl = "img/pizzas/theworks.jpg",
                Type = "Supreme"
            }
        ];
        db.Specials.AddRange(specials);
        return db.SaveChangesAsync();
    }
}