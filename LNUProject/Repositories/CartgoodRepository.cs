using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class CartgoodRepository : BaseRepository<Cartgood>, ICartgoodRepository
    {
        public CartgoodRepository(LNUProjectContext context) : base(context)
        {
        }

        public Cartgood Get(int id)
        {
            return Context.Cartgoods.FirstOrDefault(cartgood => cartgood.Id == id);
        }
    }
}
