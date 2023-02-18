using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ManagementSystemLibrary
{
    public class Trip
    {        
        public string Name { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DeparturePlace { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalPlace { get; set;}
        public double EconomyPrice { get; set; }
        public double MiddlePrice { get; set; }
        public double BusinessPrice { get; set; }
        public List<Ticket> Tickets { get; set; }
        public bool Occured { get => ArrivalDate <= DateTime.Now; }
    }
}
