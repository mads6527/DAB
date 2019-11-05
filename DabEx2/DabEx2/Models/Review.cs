using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DabEx2.Models
{
    public class Review : IEntity
    { 
        //attributes
        public int id { get; set; }
        public string text { get; set; }

        //Navigation properties
        public Resturent Resturent { get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public ICollection<Guest> Guests { get; set; }

        //Foriegn keys

        public int Resturentid { get; set; }
        public int Dishesid { get; set; }
        public int Guestsid { get; set; }
    }
}
