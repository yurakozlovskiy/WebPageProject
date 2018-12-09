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
using Unity;
using LNUProjectDTO;
using LNUProjectBLL.Interfaces;
using LNUProjectBLL;

namespace LNUProjectWPFF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GoodsModifyViewModel goodsModifyViewModel;
        GoodsListViewModel _goodsListView;
        CollectionViewSource goodsCollection;

        public MainWindow(GoodsListViewModel goodsListView, GoodsModifyViewModel goodsModifyViewModel)
        {
            _goodsListView = goodsListView;
            this.goodsModifyViewModel = goodsModifyViewModel;
            DataContext = _goodsListView;
            InitializeComponent();

            goodsCollection = (CollectionViewSource)(Resources["GoodsCollection"]);
            goodsCollection.Filter += GoodsCollection_Filter;

        }

        private void GoodsCollection_Filter(object sender, FilterEventArgs e)
        {
            var filter = txtFilter.Text;
            var good = e.Item as Goods;
            if(good.Name.Contains(filter))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private void goodsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid grid = sender as DataGrid;
            var item = (Goods)grid.SelectedItem;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            goodsCollection.View.Refresh();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            var container = Boostraper.Init();
            var detailsViewModel = container.Resolve<GoodsListViewModel>();
            var goodView = new UserModify(goodsModifyViewModel);
            goodView.ShowDialog();
            if(goodView.DialogResult.HasValue && goodView.DialogResult.Value)
            {
                _goodsListView.Update();
            }
        }
    }
}
