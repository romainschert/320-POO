using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class TankContainer : Container
    {
        public int Id { get; }
        public float Weight { get; }
        public bool IsRefrigerated { get; }
        public List<string> Merchandise { get; }
        public string Color { get; }


        public TankContainer()
        {

        }

        public void ViewContent()
        {
            foreach (var item in Merchandise)
            {
                Console.WriteLine(item);
            }
        }

        public void AddMerchandise(string item)
        {
            if (IsRefrigerated)
            {
                Merchandise.Add(item);
            }
        }
    }
}