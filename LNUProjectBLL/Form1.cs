using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNUProjectBLL.Services;
using LNUProjectBLL.Interface;
using LNUProjectDTO;
using LNUProjectBLL.Interfaces;
using Unity;
using LNUProject.UnitOfWork;

namespace LNUProjectBLL
{
    public partial class Form1 : Form
    {
        
        private readonly IUserService userService;
        private readonly IUnitOfWork unitOfWork;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(IUserService userService, IUnitOfWork unitOfWork):this()
        {
            this.userService = userService;
            this.unitOfWork = unitOfWork;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var UsersLogin = userService.SignIn();
            bool authorized = false;
            foreach (var user in UsersLogin)
            {
                if (user.Email == textBox1.Text && user.Password == textBox2.Text)
                {
                    this.Close();
                    Form2 form2 = new Form2();
                    authorized = true;
                    form2.Show();
                }
            }
            if(authorized == false)
            {
                MessageBox.Show("Enter the correct data");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
