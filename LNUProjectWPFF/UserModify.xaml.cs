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
using System.Windows.Shapes;

namespace LNUProjectWPFF
{
    /// <summary>
    /// Interaction logic for UserModify.xaml
    /// </summary>
    public partial class UserModify : Window
    {
        Goods goods;
        GoodsListViewModel goodsListView;
        GoodsModifyViewModel goodsModifyView;
        CollectionViewSource goodsCollection;
        public UserModify(GoodsListViewModel goodsListView, GoodsModifyViewModel goodsModifyView)
        {
            this.goodsModifyView = goodsModifyView;
            this.goodsListView = goodsListView;
            DataContext = goodsListView;
            InitializeComponent();
            goodsCollection = (CollectionViewSource)(Resources["GoodsCollection"]);

        }

        public UserModify(GoodsListViewModel goodsListView, GoodsModifyViewModel goodsModifyView, Goods goods)
        {
            InitializeComponent();
            this.goodsListView = goodsListView;
            this.goodsModifyView = goodsModifyView;
            this.goods = goods;
            FillData();
        }

        public void AddGood()
        {
            goodsModifyView.AddGood(NameText.Text,CategoryNameText.Text,
                Convert.ToInt32(PriceText.Text), Convert.ToInt32(QuantityText.Text));
        }

        public void UpdateGood()
        {
            goods = goodsModifyView.FillData(goods, NameText.Text, CategoryNameText.Text, Convert.ToInt32(PriceText.Text), Convert.ToInt32(QuantityText.Text));
            goodsModifyView.UpdateGood(goods);
        }
        
        

        public void FillData()
        {
            //IdText.Text = (goods.Id).ToString();
            NameText.Text = goods.Name;
            CategoryNameText.Text = goods.CategoryName;
            PriceText.Text = goods.Price.ToString();
            QuantityText.Text = goods.Quantity.ToString();

        }

        private void OKButtonClick(object sender, RoutedEventArgs e)
        {
            if (goods == null)
            {
                AddGood();
                DialogResult = true;
                return;
            }

            UpdateGood();           
            DialogResult = true;
            return;
        }
    }
}
