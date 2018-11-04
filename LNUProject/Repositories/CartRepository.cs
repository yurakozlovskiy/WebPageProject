using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class CartRepository:BaseRepository<Cart>,ICartRepository
    {
        public CartRepository(LNUProjectContext context) : base(context) { }

        public bool ContainsId(int id)
        {
            return Context.Carts.Any(cart => cart.Id == id);
        }

        public Cart Get(int id)
        {
            return Context.Carts.FirstOrDefault(cart => cart.Id == id);
        }

        public IEnumerable<Cart> GetCartByUser(int id)
        {
            return Context.Carts.Where(cart => cart.Id == id).ToList();
        }
    }
}
