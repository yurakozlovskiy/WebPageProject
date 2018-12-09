using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;

namespace LNUProjectBLL
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gOODS_SELLERDataSet.Addresses' table. You can move, or remove it, as needed.
            //this.addressesTableAdapter.Fill(this.gOODS_SELLERDataSet.Addresses);
            // TODO: This line of code loads data into the 'gOODS_SELLERDataSet.Cartgoods' table. You can move, or remove it, as needed.
     


        }

        private void cartgoodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
