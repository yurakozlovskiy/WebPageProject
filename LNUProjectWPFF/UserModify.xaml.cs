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
        GoodsModifyViewModel goodsModifyView;
        public UserModify(GoodsModifyViewModel goodsModifyView)
        {
            InitializeComponent();
            this.goodsModifyView = goodsModifyView;
        }

        public void AddGood()
        {
            goodsModifyView.AddGood(NameText.Text,CategoryComboBox.Text,
                Convert.ToInt32(PriceText.Text), Convert.ToInt32(QuantityText.Text));
        }

        public void FillData()
        {
            if(goods == null)
            {
                AddGood();
                DialogResult = true;
            }
        }

        private void OKButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
