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
namespace CourseWork.UI
{
    public partial class EditLotForm : Form
    {
        private Lot changed_lot;
        private LotRepository lotRepository = new LotRepository(new MyDbContext());
        public EditLotForm(Lot a)
        {
            changed_lot = a;
            InitializeComponent();
            Name_box.Text = changed_lot.Name;          
            int time_1 = changed_lot.StartTime;
            hours_time.Value = time_1 / 60;
            minutes_time.Value = time_1 % 60;
            date.Value = Convert.ToDateTime(changed_lot.Date);
            min_bid.Value = changed_lot.MinBid;
            Des_box.Text = changed_lot.Description;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  DateTime a =  System.DateTime.Parse(A)
            if (Name_box.Text.Length <= 0)
            {
                MessageBox.Show( "Input name for lot", "Error");
            }
            else
            {
                changed_lot.Name = Name_box.Text;
                changed_lot.Description = Des_box.Text;
                changed_lot.MinBid = (int)min_bid.Value;
                changed_lot.StartTime = (int)hours_time.Value * 60 + (int)minutes_time.Value;
                changed_lot.Date = date.Value.ToString();
                lotRepository.Update(changed_lot);
                Close();
                
            }      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
