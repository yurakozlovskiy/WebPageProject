using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNUProjectDTO
{
    public class UserDTO
    {
        public UserDTO(int id, string firstname, string lastname, string role, DateTime? date_logup, DateTime? date_birth, int? rating, string email, bool email_confirmed)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Role = role;
            Date_logup = date_logup;
            Date_birth = date_birth;
            Rating = rating;
            Email = email;
            Email_confirmed = email_confirmed;

        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Date_logup { get; set; }
        public DateTime? Date_birth { get; set; }
        public int? Rating { get; set; }

        public string Email { get; set; }
        public bool Email_confirmed { get; set; }
        public string Role { get; set; }

    }

    
}
