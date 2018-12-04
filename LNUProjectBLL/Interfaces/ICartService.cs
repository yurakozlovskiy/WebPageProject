using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;
using LNUProjectDTO;

namespace LNUProjectBLL.Interfaces
{
    public interface ICartService:IDisposable
    {
        CartDTO Get(int id);
        List<CartDTO> GetAll();
        List<CartDTO> GetCartByUser(int userid);
    }
}
