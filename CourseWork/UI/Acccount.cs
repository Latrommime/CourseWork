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
    public partial class Acccount : Form
    {
        private User user;
        private List<Lot> lots;
        LotRepository lotRepository = new LotRepository(new MyDbContext());

        public Acccount(User user)
        {
            InitializeComponent();

            this.user = user;
            this.UserName_label.Text = user.Name;

            lots = lotRepository.GetAll().ToList();

        }

        private void Acccount_Load(object sender, EventArgs e)
        {

        }
    }
}
