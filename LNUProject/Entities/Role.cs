using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Role()
        {
            Users = new HashSet<User>();
        }

        public virtual ICollection<User> Users { get; set; }

    }
}
