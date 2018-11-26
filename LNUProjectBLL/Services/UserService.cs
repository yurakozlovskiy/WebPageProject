using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.UnitOfWork;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;
using LNUProject.Entities;

namespace LNUProjectBLL.Services
{
    class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork db) : base(db)
        {
        }

        public bool ContainsId(int id)
        {
            return db.Users.ContainsId(id);
        }

        public UserDTO Get(int id)
        {
            var user = db.Users.Get(id);
            if (user == null)
                return null;
            else
                return new UserDTO(user.Id,
                                   user.Firstname,
                                   user.Lastname,
                                   user.Role.Name,
                                   user?.Date_logup,
                                   user?.Date_birth,
                                   user?.Rating,
                                   user.Email,
                                   user.Email_confirmed);
        }

        public UserDTO GetByEmail(string email)
        {
            var user = db.Users.GetByEmail(email);
            if (user == null)
                return null;
            else
                return new UserDTO(user.Id,
                                   user.Firstname,
                                   user.Lastname,
                                   user.Role.Name,
                                   user?.Date_logup,
                                   user?.Date_birth,
                                   user?.Rating,
                                   user.Email,
                                   user.Email_confirmed);

        }

        public List<UserDTO> GetByRole(int roleid)
        {
            var users = db.Users.GetUsersByRole(roleid);
            if (users == null)
                return null;
            var dtos = new List<UserDTO>();
            foreach (var user in users)
            {
                dtos.Add(new UserDTO(user.Id,
                                   user.Firstname,
                                   user.Lastname,
                                   user.Role.Name,
                                   user?.Date_logup,
                                   user?.Date_birth,
                                   user?.Rating,
                                   user.Email,
                                   user.Email_confirmed));
            }
            return dtos;

        }

        public ImageDTO GetImage(int id)
        {
            User getimage = db.Users.Get(id);
            if (getimage.Image == null || getimage.Imagename == null)
                return null;
            else
                return new ImageDTO()
                {
                    Name = getimage.Imagename,
                    Base64Data = getimage.Image
                };

        }

        public List<UserDTO> GetUsers()
        {
            var users = db.Users.GetAll();
            if (users == null)
                return null;
            var dtos = new List<UserDTO>();
            foreach(var user in users)
            {
                dtos.Add(new UserDTO(user.Id,
                                   user.Firstname,
                                   user.Lastname,
                                   user.Role.Name,
                                   user?.Date_logup,
                                   user?.Date_birth,
                                   user?.Rating,
                                   user.Email,
                                   user.Email_confirmed));
            }
            return dtos;
        }

        public List<UserLoginDTO> SignIn()
        {
            var users = db.Users.GetAll();
            if (users == null)
                return null;
            var dtos = new List<UserLoginDTO>();
            foreach (var user in users)
            {
                dtos.Add(new UserLoginDTO()
                {
                    Email= user.Email,
                    Password = user.Password
                });
            }
              
            
            return dtos;
        }
    }
}
