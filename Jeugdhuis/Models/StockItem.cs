﻿namespace Jeugdhuis.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public int DrinkId { get; set; } 
        public Drink Drink { get; set; }
        public int Quantity { get; set; }
        public int StockId { get; set; } 
        public Stock Stock { get; set; }
    }
}