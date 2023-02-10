using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType { Boing, Airbus}
    public class Plane
    {
        public int capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "capacity" + " " + capacity + " " + " date" + " " + ManufactureDate + " " + "type" + " " + PlaneType;
        }
        //public Plane(PlaneType pt,int capacity,DateTime date) {
        //    this.PlaneType = pt;
        //    this.capacity = capacity;
        //    this.ManufactureDate= date;
        //}
        //public Plane() { }
    }
}
