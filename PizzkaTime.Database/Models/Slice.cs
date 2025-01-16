using System.ComponentModel.DataAnnotations.Schema;

namespace PizzkaTime.Database.Models
{
    public class Slice 
    {
        public int SliceId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual User? User { get; set; }
        [ForeignKey(nameof(Dish))]
        public int DishId { get; set; }

        public virtual Dish? Dish { get; set; }

        
    }
}
