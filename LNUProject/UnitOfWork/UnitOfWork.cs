using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Repositories.Interfaces;
using LNUProject.Entities;
using LNUProject.Repositories;

namespace LNUProject.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LNUProjectContext context;
        private bool disposed;
        private IAddressRepository addresses;
        private ICartRepository carts;
        private ICartgoodRepository cartgoods;
        private ICategoryRepository categories;
        private IGoodRepository goods;
        private IRoleRepository roles;
        private IUserRepository users;

        public UnitOfWork(LNUProjectContext context)
        {
            this.context = context;
            disposed = false;
        }

        public IAddressRepository Addresses => addresses ?? (addresses = new AddressRepository(context));
        public ICartRepository Carts => carts ?? (carts = new CartRepository(context));
        public ICartgoodRepository Cartgoods => cartgoods ?? (cartgoods = new CartgoodRepository(context));
        public ICategoryRepository Categories => categories ?? (categories = new CategoryRepository(context));
        public IGoodRepository Goods => goods ?? (goods = new GoodRepository(context));
        public IRoleRepository Roles => roles ?? (roles = new RoleRepository(context));
        public IUserRepository Users => users ?? (users = new UserRepository(context));
        



        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
