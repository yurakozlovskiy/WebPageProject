using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProjectDTO
{
    public class GoodDTO
    {
        public GoodDTO(int id, string name, string categoryname, int price, int quantity)
        {
            Id = id;
            Name = name;
            CategoryName = categoryname;
            Price = price;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
