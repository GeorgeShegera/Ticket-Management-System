using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Train
    {
        public int TripId { get; private set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int BusinessClassCapacity { get; set; }
        public int MiddleClassCapacity { get; set; }
        public int EconomyClassCapacity { get; set; }

        public Train(string name = "", string model = "", int busCapacity = 0, int middleCapacity = 0, int economyCapacity = 0)
        {
            Name = name;
            Model = model;
            BusinessClassCapacity = busCapacity;
            MiddleClassCapacity = middleCapacity;
            EconomyClassCapacity = economyCapacity;
        }
    }
}
