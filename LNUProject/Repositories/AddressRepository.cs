using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class AddressRepository:BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(LNUProjectContext context) : base(context) { }

        public Address Get(int id)
        {
            return Context.Addresses.FirstOrDefault(address => address.Id == id);
        }

        public Address GetAddressesByUser(int userid)
        {
            return Context.Addresses.FirstOrDefault(address => address.UserId == userid);
        }
    }
}
