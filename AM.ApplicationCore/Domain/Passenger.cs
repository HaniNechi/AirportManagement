using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateOnly BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flight { get; set; }
        public override string ToString()
        {
            return "nom" + FirstName + " " + " prenom" + " " + FirstName + " " + "email" + " " + "email" + " " + EmailAddress;
        }
        public bool CheckProfile(string firstname,string lastname)
        {
            return this.FirstName==firstname && this.LastName==lastname;
        }
        public bool CheckProfile(string firstname,string lastname, string email=null) {
            if(EmailAddress!=null)
        return this.FirstName==firstname && this.LastName==lastname && this.EmailAddress==email;
            else
                return this.FirstName == firstname && this.LastName == lastname;
        }
        public virtual void PassengerType() // vitrual pour redéfinir dans la classe fille
        {
            Console.WriteLine("je suis le passager : ");
        }
    }
}
