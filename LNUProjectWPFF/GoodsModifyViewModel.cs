using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;
using AutoMapper;

namespace LNUProjectWPFF
{
    public class GoodsModifyViewModel
    {
        
        private IGoodService goodService;
        private IMapper mapper;
        public GoodsModifyViewModel(IGoodService goodService)
        {
            this.goodService = goodService;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Goods, GoodDTO>();
            });
            mapper = config.CreateMapper();
        }

        public void AddGood(string name, string categoryname, int price,int quantity)
        {
            Goods good = new Goods();
            good = FillData(good, name, categoryname, price,quantity);
            goodService.Add(mapper.Map<GoodDTO>(good));
        }
        public void Update() { }
        public Goods FillData(Goods good, string name, string categoryname, int price, int quantity)
        {
            good.Name = name;
            good.CategoryName = categoryname;
            good.Price = price;
            good.Quantity = quantity;
            return good;
        }
        
    }
}
