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

namespace LNUProjectBLL
{
    public partial class Form1 : Form
    {
        IRoleService RoleService;
        public Form1(IRoleService r)
        {
            InitializeComponent();
            RoleService=r;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            List<RoleDTO> roles = RoleService.GetAllRoles();
            foreach(var role in roles)
            {
                if(email == role.Name)

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
