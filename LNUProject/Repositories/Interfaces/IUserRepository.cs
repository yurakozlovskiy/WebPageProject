using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
        User Get(int id);
        User GetByEmail(string email);
        string GetImage(int id);
        bool ContainsId(int id);
        IEnumerable<User> GetUsersByRole(int roleid);
        string ExtractFullName(int? id);
    }
}
