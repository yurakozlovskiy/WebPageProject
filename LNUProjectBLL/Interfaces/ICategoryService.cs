using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectBLL.Interface;
using LNUProjectDTO;

namespace LNUProjectBLL.Interfaces
{
    public interface ICategoryService:IDisposableService
    {
        CategoryDTO Get(int id);
        List<CategoryDTO> GetAllCategories();
        CategoryDTO GetByName(string name);
    }
}
