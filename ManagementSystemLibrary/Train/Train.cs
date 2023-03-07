using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ManagementSystemLibrary
{
    public class Train
    {
        public List<Trip> Trips { get; set; } = new List<Trip>();
        public string Name { get; set; }
        public string Model { get; set; }
        public int BusCapacity { get; } = 343;
        public int MidCapacity { get; set; }
        public int EconCapacity { get; set; }
        public TrainState State { get; set; } = TrainState.Available;
        public string Signature
        {
            get
            {
                return $"{Name} ({GetState()})";
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

        public string GetState()
        {
            switch (State)
            {
                case TrainState.Available: return "Available";
                case TrainState.Unavailable: return "Unavailable";
                default: return "";
            }
        }

        
    }
}
