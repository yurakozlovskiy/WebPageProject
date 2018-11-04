using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface IRoleRepository:IRepository<Role>
    {
        Role Get(int id);
        Role TryGetByName(string name);
    }
}
