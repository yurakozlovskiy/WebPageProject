using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LNUProjectBLL;
using LNUProjectBLL.Interface;
using LNUProjectBLL.Interfaces;
using Unity;

namespace LNUProjectWPFF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = Boostraper.Init();
           
            GoodsListViewModel goodsListViewModel = container.Resolve<GoodsListViewModel>();
            GoodsModifyViewModel goodsModifyViewModel = container.Resolve<GoodsModifyViewModel>();
            MainWindow window = new MainWindow(goodsListViewModel, goodsModifyViewModel);
            window.Show();
        }
    }
}
