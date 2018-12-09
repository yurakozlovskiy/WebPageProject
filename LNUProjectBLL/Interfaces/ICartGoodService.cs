using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectDTO;

namespace LNUProjectBLL.Interfaces
{
    public interface ICartGoodService:IDisposable
    {
        CartgoodDTO Get(int id);
        CartgoodDTO GetBySellerId(int sellerid);
        int? GetQuantity(int id);
    }
}
