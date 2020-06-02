using CourseWork.BLL;
using CourseWork.DAL;
using System;
using System.Windows.Forms;

namespace CourseWork.UI
{
    public partial class BidForm : Form
    {
        Lot lot;
        LotRepository lotRepository = new LotRepository(new MyDbContext());

        private int _ticks = 0;
        private int timeLeft;



        public BidForm(Lot lot)
        {
            InitializeComponent();
            timer1.Start();
            this.lot = lot;
            LoadLot();
            lotRepository.LotUpdated += this.LotUpdated;
        }


        private void BidForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadLot()
        {
            textBox1.Text = lot.Name;
            richTextBox1.Text = lot.Description;
            textBox5.Text = lot.CurrentBid.ToString();
            textBox3.Text = (lot.StartTime / 60).ToString();//hours
            textBox2.Text = (lot.StartTime % 60).ToString();//minutes
            textBox4.Text = lot.MinBid.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks = DateTime.Now.Second;
            if (_ticks >= 59)
            {

                _ticks = 0;
            }
        }

        private void LotUpdated(object sender, EventArgs e)
        {

        }
    }
}
