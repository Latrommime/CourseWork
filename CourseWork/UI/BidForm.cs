using CourseWork.BLL;
using CourseWork.DAL;
using System;
using System.Windows.Forms;

namespace CourseWork.UI
{
    public partial class BidForm : Form
    {
        Lot lot;
        User user = new User() { Balance = 150 };
        static MyDbContext db = new MyDbContext();
        LotRepository lotRepository = new LotRepository(db);
        UserRepository userRepository = new UserRepository(db);

        private int maxTimeLeftInMinutes = 1;
        private float timeLeft;

        public BidForm(Lot lot, User user)
        {
            InitializeComponent();
            timer1.Start();
            timeLeft = maxTimeLeftInMinutes * 60;
            panel1.Visible = false;

            this.lot = lot;
            this.user = user;

            LoadLot();
            lotRepository.LotUpdated += this.LotUpdated;
        }

        private void BidForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadLot()
        {
            UserBalnce.Text = user.Balance.ToString();
            textBox1.Text = lot.Name;
            richTextBox1.Text = lot.Description;
            textBox3.Text = (lot.StartTime / 60).ToString();//hours
            textBox2.Text = (lot.StartTime % 60).ToString();//minutes
            textBox4.Text = lot.MinBid.ToString();
            if (lot.MinBid >= lot.CurrentBid) textBox6.Text = (60 * maxTimeLeftInMinutes).ToString();
            else textBox6.Text = ((int)timeLeft).ToString();
            dateTimePicker1.Value = Convert.ToDateTime(lot.Date);
            textBox5.Text = lot.CurrentBid.ToString();
            if (lot.CurrentBid < lot.MinBid) textBox7.Text = lot.MinBid.ToString();
            else textBox7.Text = lot.CurrentBid.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!lot.SoldOut)
            {
                if (lot.MinBid < lot.CurrentBid && timeLeft > 0f)
                {
                    timeLeft -= 0.5f;
                    textBox6.Text = Convert.ToString(timeLeft);
                }
                else if (timeLeft <= 0f)
                {
                    button1.Enabled = false;
                    panel1.Visible = true;
                    lot.SoldOut = true;
                    LotUpdated(this, new EventArgs());
                    return;
                }

                LotUpdated(this, new EventArgs());

                if (lot.CurrentBidUserId == user.Id) button1.Enabled = false;
                else button1.Enabled = true;
            }
        }

        private void LotUpdated(object sender, EventArgs e)
        {
            LotRepository lotRepository = new LotRepository(new MyDbContext());
            UserRepository userRepository = new UserRepository(new MyDbContext());
            user = userRepository.Get(user.Name);
            lot = lotRepository.Get(lot.Id);
            LoadLot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bid = Convert.ToInt32(textBox7.Text) + (int)numericUpDown1.Value;
            if (bid <= user.Balance && bid > lot.CurrentBid)
            {
                user.Balance -= bid;
                userRepository.Update(user);
                lot.CurrentBid = bid;
                lot.CurrentBidUserId = user.Id;

                lot.EndTime = DateTime.Now.Hour * 60 + DateTime.Now.Minute + maxTimeLeftInMinutes;

                timeLeft = maxTimeLeftInMinutes * 60;
                lotRepository.Update(lot);
            }
            else
            {
                MessageBox.Show("Not enougth money", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
