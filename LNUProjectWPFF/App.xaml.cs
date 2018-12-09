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
        private IUnityContainer container;
       
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = Boostraper.Init();
           
            GoodsListViewModel goodsListViewModel = container.Resolve<GoodsListViewModel>();
            MainWindow window = new MainWindow(goodsListViewModel);
            window.Show();
        }
    }
}
