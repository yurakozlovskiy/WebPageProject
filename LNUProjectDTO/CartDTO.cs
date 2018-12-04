using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProjectDTO
{
    public class CartDTO
    {
        public CartDTO(int id, string username, string sellername)
        {
            Id = id;
            UserName = username;
            SellerName = sellername;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string SellerName { get; set; }
    }
}
