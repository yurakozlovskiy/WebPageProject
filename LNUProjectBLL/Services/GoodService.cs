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
    public class GoodService : BaseService, IGoodService
    {
        public GoodService(IUnitOfWork db) : base(db)
        {
        }

        public GoodDTO Get(int id)
        {
            var user = db.Goods.Get(id);
            if (user == null)
                return null;
            else
                return new GoodDTO(user.Id,
                                   user.Name,
                                   user.Category.Name,
                                   user.Price,
                                   user.Quantity);
        }

        public List<GoodDTO> GetGoods()
        {
            var users = db.Goods.GetAll();
            if (users == null)
                return null;
            var dtos = new List<GoodDTO>();
            foreach(var user in users)
            {
                dtos.Add(new GoodDTO(user.Id,
                                     user.Name,
                                     user.Category.Name,
                                     user.Price,
                                     user.Quantity));
            }
            return dtos;
        }

        public List<GoodDTO> GetByCategories(int categoryid)
        {
            var users = db.Goods.GetGoodsByCategory(categoryid);
            if (users == null)
                return null;
            var dtos = new List<GoodDTO>();
            foreach (var user in users)
            {
                dtos.Add(new GoodDTO(user.Id,
                                     user.Name,
                                     user.Category.Name,
                                     user.Price,
                                     user.Quantity));
            }
            return dtos;
        }

        public GoodDTO GetByName(string name)
        {
            var user = db.Goods.GetByName(name);
            if (user == null)
                return null;
            else
            {
                return new GoodDTO(user.Id,
                                   user.Name,
                                   user.Category.Name,
                                   user.Price,
                                   user.Quantity);
            }
        }
    }
}
