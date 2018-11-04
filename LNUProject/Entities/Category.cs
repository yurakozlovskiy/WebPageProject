using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Category()
        {
            Goods = new HashSet<Good>();
        }

        public virtual ICollection<Good> Goods { get; set; }
    }
}
