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
        public string Category { get; set; }

        public Drink(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public Drink(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public Drink() { }
    }
}
