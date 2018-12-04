using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class GoodRepository : BaseRepository<Good>, IGoodRepository
    {
        public GoodRepository(LNUProjectContext context) : base(context)
        {
        }

        public Good Get(int id)
        {
            return Context.Goods.FirstOrDefault(good => good.Id == id);
        }

        public Good GetByName(string name)
        {
            return Context.Goods.FirstOrDefault(r => r.Name == name);
        }

        public IEnumerable<Good> GetGoodsByCategory(int categoryid)
        {
            return Context.Goods.Where(good => good.CategoryId == categoryid).ToList();
        }
    }
}
