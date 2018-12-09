using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNUProjectBLL.Interface;
using LNUProjectBLL.Interfaces;
using LNUProject.UnitOfWork;
using LNUProjectDTO;
using Unity;

namespace LNUProjectBLL
{
    public partial class Form3 : Form
    {
        private IUnityContainer container;
        private readonly ICategoryService categoryService;
        private readonly IUserService userService;
        private readonly IGoodService goodService;
        private readonly ICartGoodService cartgoodService;
        private readonly IUnitOfWork unitOfWork;

        public Form3(ICategoryService categoryService, IGoodService goodService, ICartGoodService cartgoodService,IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            container = Boostraper.Init();
            this.categoryService = categoryService;
            this.goodService = goodService;
            this.cartgoodService = cartgoodService;
            this.unitOfWork = unitOfWork;

            List<CategoryDTO> categories = categoryService.GetAllCategories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //List<GoodDTO> goods = goodService.GetGoods();
            //comboBox2.DataSource = goods;
            //comboBox2.DisplayMember = "Name";
            //comboBox2.ValueMember = "Id";
            //comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CategoryDTO> categories = categoryService.GetAllCategories();
            foreach (var category in categories)
            {
                if (category.Name == comboBox1.Text)
                {
                    List<GoodDTO> goods = goodService.GetByCategories(category.Id);
                    var cartgoods = unitOfWork.Cartgoods.GetAll();
                    
                    comboBox2.DataSource = goods;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "Id";
                    comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
                    foreach (var good in goods)
                    {
                        
                        textBox1.Text = good.Price.ToString() + " uah";
                        foreach(var cartgood in cartgoods)
                        {
                            if (good.Id == cartgood.GoodId)
                                textBox2.Text = cartgood.Quantity.ToString();
                        }
                    }
                }

            }
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var good = goodService.GetByName(comboBox2.Text);
            var cartgood = cartgoodService.GetBySellerId(EmailDTO.Id);
            
        }
    }
}
