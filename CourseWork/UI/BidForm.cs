using CourseWork.BLL;
using CourseWork.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.UI
{
    public partial class BidForm : Form
    {
        Lot lot;
        LotRepository lotRepository;

        private int _ticks = 0;
        private int timeLeft;

        public BidForm(Lot lot, User user)
        {

            InitializeComponent();
            timer1.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BidForm_Load(object sender, EventArgs e)
        {
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks = DateTime.Now.Second;
            if(_ticks >= 59)
            {
                
                _ticks = 0;
            }
        }

        private void LotUpdated(object sender, EventArgs e) { 

        }
    }
}
