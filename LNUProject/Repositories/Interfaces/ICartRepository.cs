using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface ICartRepository:IRepository<Cart>
    {
        Cart Get(int id);
        bool ContainsId(int id);
        IEnumerable<Cart> GetCartByUser(int id);
    }
}
