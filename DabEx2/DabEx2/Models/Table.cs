using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DabEx2.Models
{
    public class Table : IEntity
    {
        //Attributes
        public int id { get; set; }
        public int Number { get; set; }

        //Navigation properties
        public Resturent Resturent { get; set; }
        public TableWaiters TableWaiters { get; set; }
        public ICollection<Guest> Guests { get; set; }
    }
}
