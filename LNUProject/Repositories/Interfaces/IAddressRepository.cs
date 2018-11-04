using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface IAddressRepository:IRepository<Address>
    {
        Address Get(int id);
        Address GetAddressesByUser(int userid);
    }
}
