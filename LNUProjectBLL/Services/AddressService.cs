using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectDTO;
using LNUProjectBLL.Interfaces;
using LNUProject.UnitOfWork;

namespace LNUProjectBLL.Services
{
    public class AddressService : BaseService, IAddressService
    {
        public AddressService(IUnitOfWork db) : base(db)
        {
        }

        public AddressDTO Get(int id)
        {
            var address = db.Addresses.Get(id);
            if (address == null)
                return null;
            else
                return new AddressDTO(address.Id,
                                      address.City,
                                      address.UserId,
                                      address.Street_address,
                                      address.User.Firstname,
                                      address.User.Lastname
                                      );
        }

        public List<AddressDTO> GetAddresses()
        {
            var addresses = db.Addresses.GetAll();
            if (addresses == null)
                return null;
            var dtos = new List<AddressDTO>();
            foreach (var address in addresses)
                dtos.Add(new AddressDTO(address.Id,
                                        address.City,
                                        address.UserId,
                                        address.Street_address,
                                        address.User.Firstname,
                                        address.User.Lastname));
            return dtos;
        }

        public AddressDTO GetByUser(int id)
        {
            var address = db.Addresses.GetAddressesByUser(id);
            if (address == null)
                return null;
            else
                return new AddressDTO(address.Id,
                                        address.City,
                                        address.UserId,
                                        address.Street_address,
                                        address.User.Firstname,
                                        address.User.Lastname);
        }
    }
}
