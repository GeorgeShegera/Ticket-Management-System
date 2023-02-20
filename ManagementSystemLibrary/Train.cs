using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementSystemLibrary
{
    public class Train
    {
        public List<Trip> Trips { get; set; } = new List<Trip>();
        public string Name { get; }
        public string Model { get; }
        public int BusCapacity { get; }
        public int MidCapacity { get; }
        public int EconCapacity { get; }
        public bool Active { get; set; } = true;
        public TrainState State { get; set; } = TrainState.Available;
        public string Signature
        {
            get
            {
                string status = "";
                switch (State)
                {
                    case TrainState.Available:
                        status = "(Available)";
                        break;
                    case TrainState.Unavailable:
                        status = "(Unavailable)";
                        break;
                }
                return $"{Name} {status}";
            }
        }

        public Train(string name = "", string model = "", int busCapacity = 0, int middleCapacity = 0, int economyCapacity = 0)
        {
            Name = name;
            Model = model;
            BusCapacity = busCapacity;
            MidCapacity = middleCapacity;
            EconCapacity = economyCapacity;
        }


    }
}
