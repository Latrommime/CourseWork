using CourseWork.DAL;
using System.Data.Entity;

namespace CourseWork
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
              : base("name=MyDbContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
    }
}
