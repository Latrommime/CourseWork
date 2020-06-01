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

namespace CourseWork
{
    public partial class Auction : Form
    {
        private Acccount acccount;
        private List<Lot> lots;
        private User user;
        private LotRepository lotRepository = new LotRepository(new MyDbContext());

        public Auction(Acccount acccount, User user)
        {
            InitializeComponent();

            this.user = user;
            this.acccount = acccount;
            lots = lotRepository.GetAll().ToList();
        }

        private void Update_AvailableLots()
        {
            List<Lot> myLots = new List<Lot>();

            foreach (Lot lot in lots)
            {
                if (lot.SalerId != user.Id)
                {
                    myLots.Add(lot);
                }
            }

            dataGridView_AvailableLots.Rows.Clear();
            for (int i = 0; i < myLots.Count; i++)
            {
                dataGridView_AvailableLots.Rows.Add(myLots[i].Id.ToString(), myLots[i].Name, myLots[i].StartTime.ToString(), myLots[i].Date.ToString(), myLots[i].CurrentBid.ToString());
            }
        }

        private void Open_Account_Click(object sender, EventArgs e)
        {
            this.Hide();
            acccount.Show();
        }
    }
}
