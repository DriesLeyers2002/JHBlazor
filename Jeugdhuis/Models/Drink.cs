namespace Jeugdhuis.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceAtParty { get; set; }
        public bool IsActive { get; set; }
        public int Stock { get; set; }
    }
}
