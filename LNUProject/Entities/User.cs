using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Date_logup { get; set; }
        public DateTime? Date_birth { get; set; }
        public int? Rating { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Imagename { get; set; }
        public bool Email_confirmed { get; set; }

        public virtual Role Role { get; set; }

        public User()
        {
            Addresses = new HashSet<Address>();
            Users = new HashSet<Cart>();
            Sellers = new HashSet<Cart>();
            
        }

        public virtual ICollection<Address> Addresses{ get; set; }
        public virtual ICollection<Cart> Users { get; set; }
        public virtual ICollection<Cart> Sellers { get; set; }
    }
}
