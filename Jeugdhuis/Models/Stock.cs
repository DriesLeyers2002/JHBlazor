namespace Jeugdhuis.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public List<StockItem> DrinkStock { get; set; } = new List<StockItem>();

        public Stock()
        {
            DrinkStock = new List<StockItem>();
        }

        public bool AddDrink(Drink drink, int quantity)
        {
            var stockItem = DrinkStock.Find(item => item.Drink.Id == drink.Id);

            if (stockItem != null)
            {
                return false;
            }
            else
            {
                DrinkStock.Add(new StockItem { Drink = drink, Quantity = quantity });
                return true;
            }
        }

        public bool ChangeQuantity(Drink drink, int quantity)
        {
            var stockItem = DrinkStock.Find(item => item.Drink.Id == drink.Id);

            if (stockItem != null)
            {
                stockItem.Quantity += quantity;
                return true;
            }
            else
                return false;
        }

        public bool RemoveDrink(Drink drink, int quantity)
        {
            var stockItem = DrinkStock.Find(item => item.Drink.Id == drink.Id);

            if (stockItem != null)
            {
                DrinkStock.Remove(stockItem);

                return true; 
            }

            return false; 
        }

        public int GetStock(Drink drink)
        {
            var stockItem = DrinkStock.Find(item => item.Drink.Id == drink.Id);
            return stockItem?.Quantity ?? 0;
        }

        public List<Drink> GetAvailableDrinks()
        {
            return DrinkStock.ConvertAll(item => item.Drink);
        }
    }
}
