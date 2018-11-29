using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LNUProjectBLL
{
    public class UnityContainer
    {
        var container = new UnityContainer();


        container.RegisterType<IAddressService, AddressService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
    }
}
