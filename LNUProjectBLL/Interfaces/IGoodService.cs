using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectBLL.Interface;
using LNUProjectDTO;

namespace LNUProjectBLL.Interfaces
{
    public interface IGoodService:IDisposable
    {
        GoodDTO Get(int id);
        List<GoodDTO> GetGoods();
        GoodDTO GetByName(string name);
        List<GoodDTO> GetByCategories(int categoryid);
        void Add(GoodDTO good);
    }
}
