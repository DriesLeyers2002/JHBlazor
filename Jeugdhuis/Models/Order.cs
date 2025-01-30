namespace Jeugdhuis.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public double TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public string UserId { get; set; }

        public Order() { }

        public Order(DateTime orderDate, double totalAmount, List<OrderItem> orderItems, string userId)
        {
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            OrderItems = orderItems;
            UserId = userId;
        }

        public Order(int id, DateTime orderDate, double totalAmount, List<OrderItem> orderItems, string userId)
        {
            Id = id;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            OrderItems = orderItems;
            UserId = userId;
        }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int DrinkId { get; set; }
        public int OrderId { get; set; }
        public Drink Drink { get; set; }
        public int Quantity { get; set; }
        public double PriceAtPurchase { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int drinkId, Drink drink, int quantity, double priceAtPurchase)
        {
            DrinkId = drinkId;
            Drink = drink;
            Quantity = quantity;
            PriceAtPurchase = priceAtPurchase;
        }

        public OrderItem(int id, int drinkId, Drink drink, int quantity, double priceAtPurchase)
        {
            Id = id;
            DrinkId = drinkId;
            Drink = drink;
            Quantity = quantity;
            PriceAtPurchase = priceAtPurchase;
        }
    }
}