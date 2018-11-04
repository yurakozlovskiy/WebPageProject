using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.UnitOfWork;
using LNUProjectBLL.Interface;
using LNUProjectBLL.Services;
using LNUProjectDTO;

namespace LNUProjectBLL.Services
{
    public class RoleService : BaseService, IRoleService
    {
        public RoleService(IUnitOfWork db) : base(db)
        {
        }

        public RoleDTO Get(int id)
        {
            var role = db.Roles.Get(id);
            if (role == null)
                return null;
            else
                return new RoleDTO(role.Id, role.Name);
        }

        public List<RoleDTO> GetAllRoles()
        {
            var roles = db.Roles.GetAll();
            if (roles == null)
                return null;
            var dtos = new List<RoleDTO>();
            foreach (var role in roles)
                dtos.Add(new RoleDTO(role.Id, role.Name));
            return dtos;
        }

        public RoleDTO GetByName(string name)
        {
            var role = db.Roles.TryGetByName(name);
            if (role == null)
                return null;
            else
                return new RoleDTO(role.Id, role.Name);
        }
    }
}
