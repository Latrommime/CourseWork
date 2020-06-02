﻿using System;
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

        public void Update_LotsFromData()
        {
            lots = lotRepository.GetAll().ToList();
        }

        public void Update_AvailableLots()
        {
            List<Lot> myLots = new List<Lot>();

            foreach (Lot lot in lots)
            {
                if (lot.SalerId != user.Id && DateTime.Now.Minute > lot.StartTime && lot.EndTime < DateTime.Now.Minute && Convert.ToDateTime(lot.Date).Day == DateTime.Now.Day)
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

        public void Update_PlannedLots()
        {
            List<Lot> myLots = new List<Lot>();

            foreach (Lot lot in lots)
            {
                if (Convert.ToDateTime(lot.Date).Day != DateTime.Now.Day && DateTime.Now.Minute < lot.StartTime)
                {
                    myLots.Add(lot);
                }
            }

            dataGridView_PlannedLots.Rows.Clear();
            for (int i = 0; i < myLots.Count; i++)
            {
                dataGridView_PlannedLots.Rows.Add(myLots[i].Id.ToString(), myLots[i].Name, myLots[i].StartTime.ToString(), myLots[i].Date.ToString(), myLots[i].CurrentBid.ToString());
            }
        }

        private void Open_Account_Click(object sender, EventArgs e)
        {
            acccount.Update_LotsFromData();
            acccount.Update_MyLots();
            acccount.Update_BoughtLots();
            this.Hide();
            acccount.Show();
        }

        private void Bid_Button_Click(object sender, EventArgs e)
        {
            if(dataGridView_AvailableLots.SelectedRows.Count > 1 && dataGridView_AvailableLots.SelectedRows.Count == 0)
            {
                return;
            }

            int index = dataGridView_AvailableLots.SelectedRows[0].Index;
            int indexInDataBase = Convert.ToInt32(dataGridView_AvailableLots[0, index].Value.ToString());

            Lot choosedLot = lotRepository.Get(indexInDataBase);

            BidForm bidForm = new BidForm(choosedLot, user);
            bidForm.Show();
        }
    }
}
