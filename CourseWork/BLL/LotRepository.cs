using CourseWork.DAL;
using System;
using System.Collections.Generic;

namespace CourseWork.BLL
{
    class LotRepository : IRepository<Lot>
    {
        private MyDbContext db;

        public delegate void UpdateHandler(object source, EventArgs args);

        public event UpdateHandler LotUpdated;

        public LotRepository(MyDbContext db)
        {
            this.db = db;
        }

        public void Create(Lot item)
        {
            db.Lots.Add(item);
            Save();
            OnChanged();
        }

        public void Delete(int id)
        {
            Lot lot = db.Lots.Find(id);
            if (lot != null) db.Lots.Remove(lot);
            Save();
            OnChanged();
        }

        public Lot Get(int id)
        {
            return db.Lots.Find(id);
        }

        public IEnumerable<Lot> GetAll()
        {
            return db.Lots;
        }

        public void Update(Lot item)
        {
            db.Lots.Find(item.Id).Name = item.Name;
            db.Lots.Find(item.Id).Description = item.Description;
            db.Lots.Find(item.Id).SalerId = item.SalerId;
            db.Lots.Find(item.Id).Date = item.Date;
            db.Lots.Find(item.Id).StartTime = item.StartTime;
            db.Lots.Find(item.Id).EndTime = item.EndTime;
            db.Lots.Find(item.Id).MinBid = item.MinBid;
            db.Lots.Find(item.Id).CurrentBid = item.CurrentBid;
            db.Lots.Find(item.Id).CurrentBidUserId = item.CurrentBidUserId;
            db.Lots.Find(item.Id).BuyerId = item.BuyerId;
            db.Lots.Find(item.Id).SoldOut = item.SoldOut;

            Save();
            OnChanged();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void OnChanged()
        {
            if (LotUpdated != null) LotUpdated(this, EventArgs.Empty);
        }
    }
}
