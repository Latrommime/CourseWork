using CourseWork.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace CourseWork.BLL
{
    class LotRepository : IRepository<Lot>
    {
        private MyDbContext db;

        public LotRepository(MyDbContext db)
        {
            this.db = db;
        }

        public void Create(Lot item)
        {
            db.Lots.Add(item);
        }

        public void Delete(int id)
        {
            Lot lot = db.Lots.Find(id);
            if (lot != null) db.Lots.Remove(lot);
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
            throw new NotImplementedException();
        }
    }
}
