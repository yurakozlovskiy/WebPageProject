using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectBLL.Interface;
using LNUProjectDTO;

namespace LNUProjectBLL.Interfaces
{
    public interface IUserService:IDisposableService
    {
        UserDTO Get(int id);
        List<UserDTO> GetUsers();
        bool ContainsId(int id);
        UserDTO GetByEmail(string email);
        ImageDTO GetImage(int id);
        List<UserDTO> GetByRole(int roleid);
        List<UserLoginDTO> SignIn();
    }
}
