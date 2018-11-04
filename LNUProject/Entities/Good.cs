using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual Category Category { get; set; }

        public Good()
        {
            Cartgoods = new HashSet<Cartgood>();
        }

        public virtual ICollection<Cartgood> Cartgoods { get; set; }
    }
}
