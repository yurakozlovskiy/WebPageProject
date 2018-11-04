using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectDTO;

namespace LNUProjectBLL.Interface
{
    public interface IRoleService:IDisposableService
    {
        RoleDTO Get(int id);
        List<RoleDTO> GetAllRoles();
        RoleDTO GetByName(string name);
    }
}
