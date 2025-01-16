using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzkaTime.Database.Models
{
    public class Dish
    {
        public int DishId { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public DishType Type { get; set; }

        public bool IsSliceable { get; set; }

        public ICollection<Slice>? Slices { get; set; }

        public ICollection<>
    }

    public enum DishType
    {
        Unknown,
        Pizzka,
        Soup,
        Sushi,
        Kebab,
        Hamburger
    }
}
