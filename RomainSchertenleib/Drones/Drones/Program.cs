using System;
using System.Runtime.CompilerServices;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Buliding> bulidings = new List<Buliding>();
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();
            Drone drone = new Drone();
            Buliding buliding = new Buliding();
            Buliding buliding2 = new Buliding();
            Factory factory = new Factory();
            Store store = new Store();
            Rectangle r1 = new Rectangle(10, 10, 100, 150);
            Rectangle r2 = new Rectangle(30, 100, 150, 100); 
            Rectangle r3 = new Rectangle(200, 300, 50, 50);

            drone.x = 100;
            drone.y = 100;
            drone.name = "ben";
            fleet.Add(drone);
            bulidings.Add(buliding);
            bulidings.Add(buliding2);
            factorys.Add(factory);
            stores.Add(store);

            buliding.x = 20;
            buliding.y = 100;
            buliding2.y = 400;
            buliding2.x = 105;
            factory.y = 32;
            factory.x = 500;
            store.y = 130;
            store.x = 490;

         


            try
            {
                //Drone drone= new Drone();
                //Drone.MaMethode(5);

                if (fleet.Count() > 10)
                {
                    throw new ArgumentException ("La valeur de x est inf�rieure � 10 !");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Erreur : {e.Message}");
            }
            // D�marrage
            try
            {
                Application.Run(new AirSpace(fleet, bulidings, factorys, stores));
            }
            catch (Exception e)
            {
                throw new Exception("Il y a eu une erreur");
            }
        }
    }
}