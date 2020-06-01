using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.DAL;
using CourseWork.BLL;

namespace CourseWork
{
    public partial class Form1 : Form
    {
      private  MyDbContext bas = new MyDbContext();
        UserRepository userRepository = new UserRepository(new MyDbContext());
        User user;
        Acccount acccount;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                user = userRepository.Get(textBox1.Text);
                if(user.Password.Length > 0)
                {
                    if (user.Password.Equals(textBox2.Text))
                    {
                        acccount = new Acccount(user);
                        this.Hide();
                        acccount.Show(); // відкривається форма account.cs
                    }
                    else
                    {
                        MessageBox.Show("Error wrong password");
                    }
                }
                else
                {
                    if(textBox2.Text.Length > 0)
                    {
                        user.Password = textBox2.Text;
                        userRepository.Update(user);
                        acccount = new Acccount(user);
                        this.Hide();
                        acccount.Show();
                    }
                }
            }
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
