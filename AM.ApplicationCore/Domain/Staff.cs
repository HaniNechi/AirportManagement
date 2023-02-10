using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateOnly EmployementDate { get; set; }
        public string Function { get; set; }
        public float Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + " "+"date emploi" + " "+ EmployementDate+" "+ "fonction"+" "+Function+ " "+ " "+Salary;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("membre du staff");
        }
    }
}
