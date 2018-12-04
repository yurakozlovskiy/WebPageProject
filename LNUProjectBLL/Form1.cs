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
using System.Text.RegularExpressions;


namespace LNUProjectBLL
{
    public partial class Form1 : Form
    {
        
        private readonly IUserService userService;
        private readonly IUnitOfWork unitOfWork;
        private IUnityContainer container;
        
        public Form1(IUserService userService, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            Control.IsKeyLocked(Keys.CapsLock);
            this.userService = userService;
            this.unitOfWork = unitOfWork;
            container = Boostraper.Init();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ValidEmail(ValidationRules.EMAIL_REGEX, textBox1.Text);
            ValidPassword(ValidationRules.ONLY_LETTERS_AND_NUMBERS, textBox2.Text);
            var UserLogin = userService.GetUserLoginDTO();
            bool authorized = false;
            foreach (var user in UserLogin)
            {
                if (user.Email == textBox1.Text && user.Password == textBox2.Text)
                {
                    this.Hide();
                    EmailDTO.Email = textBox1.Text;
                    Form form2 = container.Resolve<Form2>();
   
                    authorized = true;
                    form2.Show();
                }
                if (user.Email == textBox1.Text && user.Password != textBox2.Text)
                {
                    MessageBox.Show("Wrong password!");
                    authorized = true;
                }
            }
            if (authorized == false && isValid(textBox1.Text,textBox2.Text))
            {
                MessageBox.Show("You are not authorized!");
            }


        }

        public void ValidEmail(string reg, string email)
        {
            Regex regex = new Regex(reg);
            if(!regex.IsMatch(email))
            {
                label4.ForeColor = Color.Red;
                label4.Text = "!Enter the correct email";
            }
        }

        public void ValidPassword(string reg, string password)
        {
            Regex regex = new Regex(reg);
            if (!regex.IsMatch(password))
            {
                label5.ForeColor = Color.Red;
                label5.Text = "!Enter the correct password";
            }

        }

        public bool isValid(string email,string password)
        {
            bool check = false;
            string reg1 = ValidationRules.EMAIL_REGEX;
            string reg2 = ValidationRules.ONLY_LETTERS_AND_NUMBERS;
            Regex regex1 = new Regex(reg1);
            Regex regex2 = new Regex(reg2);
            if(regex1.IsMatch(email) && regex2.IsMatch(password))
            {
                check = true;
                label4.Text = "";
                label5.Text = "";
            }
            return check;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
