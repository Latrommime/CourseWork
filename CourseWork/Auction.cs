using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Auction
    {
        [Key]
        public int Id { get; set; }
        public int LotId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int MinBid { get; set; }
        public int CurrentBid { get; set; }
        public int currentBidUserId { get; set; }
    }
}
