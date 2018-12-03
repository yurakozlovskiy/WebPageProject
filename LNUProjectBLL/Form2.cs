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

namespace LNUProjectBLL
{
    public partial class Form2 : Form
    {
        private IUnityContainer container;
        public Form2()
        {
            InitializeComponent();
            container = Boostraper.Init();
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
