using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectBLL.Interface;
using LNUProject.UnitOfWork;

namespace LNUProjectBLL.Services
{
    public class BaseService : IDisposableService
    {
        protected readonly IUnitOfWork db;
        public BaseService(IUnitOfWork db)
        {
            this.db = db;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
