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
        public TicketState State { get; private set; } = TicketState.New;
        public string Signature
        {
            get => $"Ticket ({GetState()})";
        }

        public void CancelTrip() => State = TicketState.Canceled;

        public string GetState()
        {
            switch(State)
            {
                case TicketState.New: return "New";
                case TicketState.Purchased: return "Purchased";
                case TicketState.Canceled: return "Canceled";
                case TicketState.Closed: return "Closed";
                default: return "";
            }
        }
        public Ticket(TicketType ticketType, double price)
        {
            TypeOfTicket = ticketType;
            DateOfPurchase = null;
            Price = price;
            Owner = null;            
        }
    }
}
