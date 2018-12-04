using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.UnitOfWork;
using LNUProjectBLL.Interface;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;

namespace LNUProjectBLL.Services
{
    public class CartService : BaseService, ICartService
    {
        public CartService(IUnitOfWork db) : base(db)
        {
        }

        public CartDTO Get(int id)
        {
            var user = db.Carts.Get(id);
            if (user == null)
                return null;
            else
            {
                return new CartDTO(user.Id,
                                    user.User.Lastname,
                                    user.Seller.Lastname);
            }
        }

        public List<CartDTO> GetAll()
        {
            var users = db.Carts.GetAll();
            if (users == null)
                return null;
            var dtos = new List<CartDTO>();
            foreach(var user in users)
            {
                dtos.Add(new CartDTO(user.Id,
                                     user.User.Lastname,
                                     user.Seller.Lastname));
            }
            return dtos;
        }

        public List<CartDTO> GetCartByUser(int userid)
        {
            var users = db.Carts.GetCartByUser(userid);
            if (users == null)
                return null;
            var dtos = new List<CartDTO>();
            foreach(var user in users)
            {
                dtos.Add(new CartDTO(user.Id,
                                     user.User.Lastname,
                                     user.Seller.Lastname));
            }
            return dtos;
        }
    }
}
