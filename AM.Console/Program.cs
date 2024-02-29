// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

/*Console.WriteLine("Hello, World!");
Flight f = new Flight();
Flight f3args = new Flight(1, DateTime.Now, 4);
Flight fDotNet = new Flight(2, DateTime.Now, 3) { Departure = "siu" };
Flight fff = new Flight()
{
    Flight f1 = new Flight(),
    FlightDate f2 = new Flight(),
};

f.FlightId = 1;
f.Departure = "ererer";
Console.WriteLine(f);*/
  FlightMethod flightMethod = new();
/*Console.WriteLine(flightMethod.ProgrammedFlightNumber(new DateTime(2000, 01, 01)));
foreach (var item in flightMethod.SeniorTravellers(TestData.flight1))
{
    Console.WriteLine(item.BirthDate);
}*/

flightMethod.DestinationGroupedFlights();


