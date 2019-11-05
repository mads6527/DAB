using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DabEx2.Models
{
    public class Dish : IEntity
    {
        //Attributes
        public int id { get; set; }
        public double price { get; set; }
        public string type { get; set; }

        //Navigation properties
        public  ResturentDishes ResturentDishes { get; set; }
        public Review Review { get; set; }
        public ICollection<Guest> Guests { get; set; }
    }
}
