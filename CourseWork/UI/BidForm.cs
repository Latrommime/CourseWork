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

        private int _ticks = 0;
        private int timeLeft;
        private int maxTimeLeftInMinutes = 2;



        public BidForm(Lot lot, User user)
        {
            InitializeComponent();
            timer1.Start();

            //TODO: change 
            lotRepository.Create(lot);
            this.lot = lotRepository.Get(lot.Id);
            
            userRepository.Create(user); //TODO: change to this.user = user;
            this.user = userRepository.Get(user.Name);
            // end 

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
            if (textBox6.Text == String.Empty) textBox6.Text = ((lot.EndTime - lot.StartTime) * 60).ToString();
            else textBox6.Text = timeLeft.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(lot.Date);
            textBox5.Text = lot.CurrentBid.ToString();
            if (lot.CurrentBid < lot.MinBid) textBox7.Text = lot.MinBid.ToString();
            else textBox7.Text = lot.CurrentBid.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = (Convert.ToInt32(textBox6.Text));
            if (timeLeft > 0) textBox6.Text = Convert.ToString(timeLeft - 0.5);
            LotUpdated(this, new EventArgs());
            _ticks = 0;
            _ticks = DateTime.Now.Second;
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
                if (lot.EndTime == 0)
                    lot.EndTime = DateTime.Now.Hour * 60 + DateTime.Now.Minute + maxTimeLeftInMinutes;
                else lot.EndTime += maxTimeLeftInMinutes;
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
