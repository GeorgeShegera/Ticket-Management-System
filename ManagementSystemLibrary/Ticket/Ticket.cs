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
        public string OwnerName { get; set; } = null;
        public TicketState State { get; set; } = TicketState.New;
        public string Signature
        {
            get => $"Ticket ({GetState()})";
        }

        public void ChangeState(TripState tripState)
        {
            switch (tripState)
            {
                case TripState.Canceled: State = TicketState.Canceled; break;
                case TripState.Complete: State = TicketState.Closed; break;
                default: State = TicketState.New; break;
            }
        }

        public string GetState()
        {
            switch (State)
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
            OwnerName = null;
        }
        public bool CheckOwner(string ownerName)
        {
            if (OwnerName != null) return ownerName == OwnerName;
            else return false;
        }
    }
}
