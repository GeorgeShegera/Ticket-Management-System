using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ManagementSystemLibrary
{
    public class Trip
    {
        public string Name { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DeparturePlace { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalPlace { get; set; }
        public double EconomyPrice { get; set; }
        public double MiddlePrice { get; set; }
        public double BusinessPrice { get; set; }
        public List<Ticket> Tickets { get; set; }
        public TripState State { get; set; } = TripState.Upcoming;

        public void ChangeState(TripState state)
        {
            State = state;
            foreach (Ticket ticket in Tickets)
                ticket.ChangeState(state);
        }

        public string Signature
        {
            get => $"{Name} ({GetState()})";
        }

        public string GetState()
        {
            switch (State)
            {
                case TripState.Upcoming: return "Upcoming";
                case TripState.Canceled: return "Canceled";
                case TripState.Complete: return "Happened";
                default: return "";
            }
        }

        public Trip(string name, DateTime departureDate, string departurePlace,
                DateTime arrivalDate, string arrivalPlace, double economyPrice,
                double middlePrice, double businessPrice, List<Ticket> tickets)
        {
            Name = name;            
            DepartureDate = departureDate;
            DeparturePlace = departurePlace;
            ArrivalDate = arrivalDate;
            ArrivalPlace = arrivalPlace;
            EconomyPrice = economyPrice;
            MiddlePrice = middlePrice;
            BusinessPrice = businessPrice;
            Tickets = tickets;
        }
        public Trip() : this("", DateTime.Now, "", DateTime.Now, "", 0, 0, 0, new List<Ticket>()) { }
    }
}
