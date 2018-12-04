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
        public Form3(ICategoryService categoryService, IGoodService goodService)
        {
            InitializeComponent();
            container = Boostraper.Init();
            this.categoryService = categoryService;
            this.goodService = goodService;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CategoryDTO> categories = categoryService.GetAllCategories();
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
