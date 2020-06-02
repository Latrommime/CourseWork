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
    public partial class AddLotForm : Form
    {
        LotRepository lotRepository = new LotRepository(new MyDbContext());
        private User user;
        public AddLotForm(User a)
        {
            InitializeComponent();
            user = a;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Enter a name", "Erorr");
            }
            else
            {
                Lot new_lot = new Lot();
                new_lot.SalerId = user.Id;           
                new_lot.Name = textBox1.Text;
                new_lot.MinBid = Convert.ToInt32(numericUpDown3.Value);
                new_lot.StartTime = Convert.ToInt32(numericUpDown1.Value * 60 + numericUpDown2.Value);
                new_lot.Description = richTextBox1.Text;
                new_lot.Date = dateTimePicker1.Value.ToString();
                lotRepository.Create(new_lot);
                Close();
            }              

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
