using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.ComponentModel;
using Boat;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Boat.Container container = new Boat.Container();
            Boat.Container refrigeratedContainer = new RefrigeratedContainer();
            Boat.Container sensitiveContainer = new SensitiveContainer();
            Boat.Container tankContainer = new TankContainer();
        }
    }
}