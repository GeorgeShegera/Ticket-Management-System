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
        public List<Trip> Trips { get; set; } = new List<Trip>();
        public string Name { get; }
        public string Model { get; }
        public int BusinessClassCapacity { get; }
        public int MiddleClassCapacity { get; }
        public int EconomyClassCapacity { get; }

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
