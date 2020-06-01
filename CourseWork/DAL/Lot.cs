using System.ComponentModel.DataAnnotations;

namespace CourseWork.DAL
{
    public class Lot
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalerId { get; set; }
        public int BuyerId { get; set; }

        public bool SoldOut { get; set; }

        public string Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public int MinBid { get; set; }
        public int CurrentBid { get; set; }
        public int CurrentBidUserId { get; set; }
    }
}
