using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SellerId { get; set; }

        public virtual User User { get; set; }
        public virtual User Seller { get; set; }

        public Cart()
        {
            Cartgoods = new HashSet<Cartgood>();
        }
        public virtual ICollection<Cartgood> Cartgoods { get; set; }
        
    }
}
