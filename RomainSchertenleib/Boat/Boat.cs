using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class boat : IBoat
    {
        public string Name { get; }
        public float MaxCargoWeight { get; }
        public int MaxSpeed { get; }
        public List<IContainer> CargoList = new List<IContainer>();

        public boat()
        {
         
        }

        public void Start()
        {
            
        }

        public bool LoadContainer(IContainer container)
        {
            float TotalContainerWeigth = 0;
            foreach (var c in CargoList)
            {
                TotalContainerWeigth += c.Weight;
            }
          
            if ((MaxCargoWeight - TotalContainerWeigth) > container.Weight)
            {
                CargoList.Add(container);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool UnloadContainer(IContainer container)
        {
            foreach (var c in CargoList)
            {
                if (c == container)
                {
                    CargoList.Remove(c);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}