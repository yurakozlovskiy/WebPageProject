using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProjectDTO
{
    public class AddressDTO
    {
        public AddressDTO(int id, string city, int userid, string street_address, string userfirstname, string userlastname)
        {
            Id = id;
            City = city;
            UserId = userid;
            Street_address = street_address;
            UserFirstName = userfirstname;
            UserLastName = userlastname;
        }

        public int Id { get; set; }
        public string City { get; set; }
        public int UserId { get; set; }
        public string Street_address { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

    }
}
