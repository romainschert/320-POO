namespace UML_RomainSchertenleib
{
    public class Cars
    {
        public int speed;
        private string _color;
        private string _model;
        private List<Passenger> passes = new List<Passenger>();
        public Cars(int speed, string color, string model)
        {
            this.speed = speed;
            _color = color;
            _model = model;
        }

        public void start()
        {
            Console.WriteLine("la voiture demarre");
        }

        public void stop()
        {
            Console.WriteLine("la voiture s'arrete");
        }

        public void takepassenger(Passenger passenger)
        {
            passes.Add(passenger);
            Console.WriteLine("la voiture a take " + passenger._name);
        }

        public void showpassenger()
        {
            foreach (Passenger passenger in passes)
            {
                Console.WriteLine("passenger " + passenger._name);
            }
           
        }

        public void droppassenger(Passenger passenger)
        {
            passes.Remove(passenger);
            Console.WriteLine("la voiture a drop " + passenger._name);
        }
    }

}
