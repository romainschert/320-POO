namespace UML_RomainSchertenleib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars(2000,"black","prenium");
            Passenger ben = new Passenger("ten");
            Passenger the = new Passenger("rock");


            cars.takepassenger(ben);
            cars.start();
            cars.showpassenger();
            cars.stop();
            cars.takepassenger(the);
            cars.start();
            cars.showpassenger();
            cars.stop();
            cars.droppassenger(ben);
            cars.droppassenger(the);

        }
    }
}
