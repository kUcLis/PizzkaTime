using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzkaTime.Database.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public string RestaurantName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string? Url { get; set; }

        public ICollection<Dish>? Menu { get; set; }
    }
}
