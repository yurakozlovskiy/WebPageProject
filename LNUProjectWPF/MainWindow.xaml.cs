using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;
using Unity;


namespace LNUProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IGoodService goodService;
        public List<GoodDTO> goods;
        public MainWindow(IGoodService goodService)
        {
            InitializeComponent();
            //this.goodService = goodService;
            //goods = goodService.GetGoods();
            //this.DataContext = goods;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
