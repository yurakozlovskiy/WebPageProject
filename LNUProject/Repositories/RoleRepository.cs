using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;
using System.Data.Entity;

namespace LNUProject.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(LNUProjectContext context):base(context) { }

        public Role Get(int id)
        {
            return Context.Roles.FirstOrDefault(r => r.Id == id);
        }

        public Role TryGetByName(string name)
        {
            return Context.Roles.FirstOrDefault(r => r.Name == name);
        }
    }
}
