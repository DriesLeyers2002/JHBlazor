namespace Jeugdhuis.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceAtParty { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsOnlyAtPart { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Drink(string name, double price, Category category, int categoryId)
        {
            Name = name;
            Price = price;
            Category = category;
            CategoryId = categoryId;
        }

        public Drink(int id, string name, double price, Category category, int categoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            CategoryId = categoryId;
        }

        public Drink() { }
    }
}
