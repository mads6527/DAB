using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DabEx2.Models
{
    public class Resturent : IEntity
    {
        //Attributes
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        //NavigationProberties
        public ResturentDishes dishes { get; set; }
        public ICollection<Table> Tables { get; set; }
        public  ICollection<Review> Reviews { get; set; }

        //ForiegnKeys

        public int TableId { get; set; }
        public  int ResturentDishesId { get; set; }
        public int ReviewId { get; set; }
    }
}
