using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Ticket
    {
        public DateTime? DateOfPurchase { get; private set; }
        public TicketType TypeOfTicket { get; private set; }
        public double Price { get; private set; }
        public string Owner { get; set; } = null;
        public bool Active { get; set; }
        public Ticket(TicketType ticketType, DateTime depatureTime)
        {
            TypeOfTicket = ticketType;
            DateOfPurchase = null;
            Price = 0;
            Owner = null;
            Active = depatureTime > DateTime.Now;
        }
    }
}
