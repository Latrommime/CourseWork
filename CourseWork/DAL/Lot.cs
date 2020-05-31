using System.ComponentModel.DataAnnotations;

namespace CourseWork.DAL
{
    class Lot
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SalerId { get; set; }
        public int BuyerId { get; set; }
    }
}
