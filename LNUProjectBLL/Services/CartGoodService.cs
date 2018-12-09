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
    public class CartGoodService : BaseService, ICartGoodService
    {
        public CartGoodService(IUnitOfWork db) : base(db)
        {
        }

        public CartgoodDTO Get(int id)
        {
            var cartgood = db.Cartgoods.Get(id);
            if (cartgood == null)
                return null;
            else
            {
                return new CartgoodDTO(cartgood.Id,
                                       cartgood.Good.Name,
                                       cartgood.Good.Category.Name,
                                       cartgood.Good.Price,
                                       cartgood.Cart.Seller.Lastname,
                                       cartgood.Quantity);
            }
        }

        public CartgoodDTO GetBySellerId(int sellerid)
        {
            var cart = db.Carts.GetCartByUser(sellerid);
            var cartgood = db.Cartgoods.GetByCartId(cart.Seller.Id);
            if (cartgood == null)
                return null;
            else
            {
                return new CartgoodDTO(cartgood.Id,
                                       cartgood.Good.Name,
                                       cartgood.Good.Category.Name,
                                       cartgood.Good.Price,
                                       cartgood.Cart.Seller.Lastname,
                                       cartgood.Quantity);
            }

        }

        public int? GetQuantity(int id)
        {
            var cartgood = db.Cartgoods.Get(id);
            
            return cartgood.Quantity;
        }
    }
}
