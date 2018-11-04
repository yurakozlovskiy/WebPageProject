using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectDTO;
using LNUProject.UnitOfWork;

namespace LNUProjectBLL.Interfaces
{
    public interface IAddressService:IDisposable
    {
        AddressDTO Get(int id);
        List<AddressDTO> GetAddresses();
        AddressDTO GetByUser(int id);
    }
}
