using CourseWork.DAL;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseWork.BLL
{
    class UserRepository : IRepository<User>
    {
        MyDbContext db;
        public UserRepository(MyDbContext db)
        {
            this.db = db;
        }
        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null) db.Users.Remove(user);
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Get(string name)
        {
            User user = null;
            foreach (User u in db.Users)
            {
                if (u.Name == name) user = u;
            }
            if (user != null) return user;
            else
            {
                Create(new User() { Name = name });
                db.SaveChanges();
                return Get(name);
            }
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public IEnumerable<Lot> GetLots()
        {
            List<Lot> lots = new List<Lot>();
            foreach(Lot lot in db.Lots)
            {
                lots.Add(lot);
            }
            return lots;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
