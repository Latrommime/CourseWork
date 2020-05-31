using CourseWork.DAL;
using System.Data.Entity;

namespace CourseWork
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
              : base("name=MyDbContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Auction> Auctions { get; set; }
    }
}
