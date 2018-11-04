using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class Cartgood
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int CartId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Date_purchase { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Good Good { get; set; }


        

    }
}
