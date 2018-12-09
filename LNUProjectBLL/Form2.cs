using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using LNUProjectDTO;
using LNUProjectBLL.Interfaces;

namespace LNUProjectBLL
{
    public partial class Form2 : Form
    {
        private readonly IUserService userService;
        private readonly ICartService cartService;
        private IUnityContainer container;
        
        public Form2(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
            container = Boostraper.Init();
            GetProfileId();
            ProfileDetails(userService);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = container.Resolve<Form1>();
            form1.Show();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = container.Resolve<Form3>();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void GetProfileId()
        {
            string email = EmailDTO.Email;
            var user = userService.GetByEmail(email);
            EmailDTO.Id = user.Id;   
        }

        public void ProfileDetails(IUserService userService)
        {
            string email = EmailDTO.Email;
            var user = userService.GetByEmail(email);
            label1.Text =  " Welcome back, " + user.Firstname+"!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = container.Resolve<Form4>();
            form4.Show();
        }
    }
}
