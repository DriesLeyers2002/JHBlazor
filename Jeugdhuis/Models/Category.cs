namespace Jeugdhuis.Models
{
    public class Category : IComparable<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Category() { }

        public Category(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public Category(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public int CompareTo(Category? other)
        {
            if (other == null) return 1;

            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}
