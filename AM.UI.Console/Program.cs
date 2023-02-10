// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using System.ComponentModel.DataAnnotations;

//Console.WriteLine("Hello, World!");
//Plane p1= new Plane();
//p1.capacity = 200;
//p1.ManufactureDate = new DateTime(2023, 02,02);
//p1.PlaneType = PlaneType.Airbus;
//p1.PlaneId= 1;
//Console.WriteLine(p1); //p1.tostring
//Plane p2= new Plane(PlaneType.Boing,200, DateTime.Now);
//Console.WriteLine(p2);
Plane p3 = new Plane {
    capacity = 100,
    PlaneType=PlaneType.Airbus,
    ManufactureDate=DateTime.Today,

};
Console.WriteLine(p3);
Passenger pass1 = new Passenger {
    FirstName = "mohamed iheb",
    LastName="berraies",
    EmailAddress="Email@gmail.com",
};
   Console.WriteLine(pass1.CheckProfile("mohamed iheb","berraies","Email@gmail.com"));
Passenger pass2 = new Staff { 
FirstName="nom",
LastName="prenom",
Function="steward",
Salary=1500,
};
pass2.PassengerType();
Passenger pass3 = new Traveller
{
    FirstName = "nom",
    LastName = "prenom",
    HealthInformation = "mizel yetnafes",
    Nationality = "zimbabwe",
};
pass3.PassengerType();