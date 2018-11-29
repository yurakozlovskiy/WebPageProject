using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.UnitOfWork;
using LNUProjectBLL.Interface;
using LNUProjectBLL.Interfaces;
using LNUProjectBLL.Services;
using Unity;

namespace LNUProjectBLL
{
    public static class Boostraper
    {
        public static IUnityContainer  Init()
        {
            var container = new UnityContainer();


            container.RegisterType<IAddressService, AddressService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            return container;
        }
    }
}
