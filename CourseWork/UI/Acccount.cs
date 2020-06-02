using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.BLL;
using CourseWork.DAL;
using CourseWork.UI;

namespace CourseWork
{
    public partial class Acccount : Form
    {
        private User user;
        private List<Lot> lots;
        MyDbContext db = new MyDbContext();
        LotRepository lotRepository;
        UserRepository userRepository;

        private Auction auction;

        public Acccount(User user)
        {
            lotRepository = new LotRepository(db);
            userRepository = new UserRepository(db);
            InitializeComponent();

            this.user = user;
            this.UserName_label.Text = user.Name;

            Update_LotsFromData();
            Update_MyLots();
            Update_BoughtLots();
            Update_Balance();
        }

        public void Update_User()
        {
            user = userRepository.Get(user.Id);
        }

        public void Update_LotsFromData()
        {
            Update_Balance();
            lots = lotRepository.GetAll().ToList();
        }

        public void Update_MyLots()
        {
            List<Lot> myLots = new List<Lot>();

            foreach (Lot lot in lots)
            {
                if (lot.SalerId == user.Id && lot.SoldOut != true)
                {
                    myLots.Add(lot);
                }
            }

            dataGridView_MyLots.Rows.Clear();
            for (int i = 0; i < myLots.Count; i++)
            {
                dataGridView_MyLots.Rows.Add(myLots[i].Id.ToString(), myLots[i].Name, myLots[i].StartTime.ToString(), myLots[i].Date.ToString(), myLots[i].CurrentBid.ToString());
            }
        }

        public void Update_BoughtLots()
        {
            List<Lot> myLots = new List<Lot>();

            foreach (Lot lot in lots)
            {
                if (lot.BuyerId == user.Id)
                {
                    myLots.Add(lot);
                }
            }

            dataGridView_BoughtLots.Rows.Clear();
            for (int i = 0; i < myLots.Count; i++)
            {
                dataGridView_BoughtLots.Rows.Add(myLots[i].Id.ToString(), myLots[i].Name, myLots[i].StartTime.ToString(), myLots[i].Date.ToString(), myLots[i].CurrentBid.ToString());
            }
        }

        private void Open_Auction_Click(object sender, EventArgs e)
        {
            if (auction == null)
            {
                auction = new Auction(db, this, user);
            }
            else
            {
                auction.Update_LotsFromData();
                auction.Update_AvailableLots();
                auction.Update_PlannedLots();
            }

            this.Hide();
            auction.Show();
        }

        private void Add_Button_Click_1(object sender, EventArgs e)
        {
            AddLotForm addLotForm = new AddLotForm(user);
            addLotForm.Show();
        }

        private void Edit_Button_Click_1(object sender, EventArgs e)
        {
            if (dataGridView_MyLots.SelectedRows.Count != 1)
            {
                return;
            }

            int index = dataGridView_MyLots.SelectedRows[0].Index;
            int indexInDataBase = Convert.ToInt32(dataGridView_MyLots[0, index].Value.ToString());

            Lot choosedLot = lotRepository.Get(indexInDataBase);

            EditLotForm editLotForm = new EditLotForm(choosedLot);
            editLotForm.Show();
        }

        private void Acccount_Load(object sender, EventArgs e)
        {

        }

        private void Replenish_Button_Click(object sender, EventArgs e)
        {
            user.Balance += 1000;
            Update_Balance();
            userRepository.Update(user);
        }

        public void Update_Balance()
        {
            Balance_label.Text = user.Balance.ToString();
        }
    }
}