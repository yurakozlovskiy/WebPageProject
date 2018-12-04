using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNUProjectBLL.Interfaces;
using LNUProjectBLL.Services;
using LNUProject.UnitOfWork;
using Unity;
using Unity.Injection;
using LNUProjectBLL.Interface;

namespace LNUProjectBLL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*var container = new UnityContainer();

            
            container.RegisterType<IAddressService, AddressService>();
            container.RegisterType<ICategoryService, CategoryService>();
            container.RegisterType<IRoleService,RoleService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();*/
            var container = Boostraper.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form3>());
        }
    }
}
