using System;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IAddressRepository Addresses { get; }
        ICartRepository Carts { get; }
        ICategoryRepository Categories { get; }
        IGoodRepository Goods { get; }
        ICartgoodRepository Cartgoods { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        void Save();
    }
}
