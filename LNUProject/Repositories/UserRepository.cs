using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public UserRepository(LNUProjectContext context) : base(context) { }

        public bool ContainsId(int id)
        {
            return Context.Users.Any(user => user.Id == id);
        }

        public string ExtractFullName(int? id)
        {
            if (id == null)
                return null;

            User finduser = Context.Users.FirstOrDefault(user => user.Id == id);
            string fullname=null;
            if (finduser != null)
                fullname = string.Concat(finduser.Firstname, " ", finduser.Lastname);

            return fullname;
        }

        public User Get(int id)
        {
            return Context.Users.FirstOrDefault(user => user.Id == id);
        }

        public User GetByEmail(string email)
        {
            return Context.Users.FirstOrDefault(user => user.Email == email);
        }

        public string GetImage(int id)
        {
            User finduser = Context.Users.FirstOrDefault(user => user.Id == id);
            return finduser?.Image;
        }

        public IEnumerable<User> GetUsersByRole(int roleid)
        {
            return Context.Users.Where(user => user.RoleId == roleid).ToList();
        }
    }
}
