namespace BlazingPizza.Models;

public class Order
{
    public int OrderId { get; set; }

    public string? UserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public Address DeliveryAddress { get; set; } = new();

    public PaymentInfo Payment { get; set; } = new PaymentInfo();

    public List<Pizza> Pizzas { get; set; } = [];

    public string Type { get; set; } = string.Empty;

    

    public decimal GetTotalPrice() =>
        Pizzas.Sum(p => p.GetTotalPrice());

    public string GetFormattedTotalPrice() =>
        GetTotalPrice().ToString("0.00");
    // In Order.cs
    
}

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Default, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(Order))]
[JsonSerializable(typeof(OrderWithStatus))]
[JsonSerializable(typeof(List<OrderWithStatus>))]
[JsonSerializable(typeof(Pizza))]
[JsonSerializable(typeof(List<PizzaSpecial>))]
[JsonSerializable(typeof(List<Topping>))]
[JsonSerializable(typeof(Topping))]
[JsonSerializable(typeof(Dictionary<string, string>))]
public partial class OrderContext : JsonSerializerContext { }