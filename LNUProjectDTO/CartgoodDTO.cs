using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProjectDTO
{
    public class CartgoodDTO
    {
        public CartgoodDTO(int id, string goodname, string goodcategory, int goodprice, string lastname, int? quantity)
        {
            Id = id;
            GoodName = goodname;
            GoodCategory = goodcategory;
            GoodPrice = goodprice;
            
            LastName = lastname;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public string GoodName { get; set; }
        public string GoodCategory { get; set; }
        public int GoodPrice { get; set; }
        
        public string LastName { get; set; }

        public int? Quantity { get; set; }
    }
}
