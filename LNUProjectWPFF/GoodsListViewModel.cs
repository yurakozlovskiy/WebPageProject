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
    public class GoodsListViewModel : INotifyPropertyChanged
    {
        private IGoodService goodService;
        private ICategoryService categoryService;
        private IMapper mapper;
        private ObservableCollection<Goods> goodList;
        public ObservableCollection<Goods>  GoodList
        {
            get { return goodList; }
            set
            {
                goodList = value;
                OnPropertyChanged(nameof(GoodList));
            }
        }
        

       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public GoodsListViewModel(IGoodService goodService,ICategoryService categoryService)
        {
            this.goodService = goodService;
            this.categoryService = categoryService;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Goods, GoodDTO>();
            });
            mapper = config.CreateMapper();
          
            Update();

        }

        public void Update()
        {
            var goods = mapper.Map<List<Goods>>(goodService.GetGoods());
            GoodList = new ObservableCollection<Goods>(goods);
        }

    }
}
