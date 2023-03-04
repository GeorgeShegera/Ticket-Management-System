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
        public int Id { get; set; }
        public TicketType Type { get; set; }
        public double Price { get; set; }
        public TicketState State { get; set; } = TicketState.New;
        public string OwnerName { get; set; } = null;
        public DateTime? DateOfPurchase { get; set; }
        public string SignatureState
        {
            get => $"Ticket ({GetState()})";
        }
        public string SignatureId
        {
            get => $"Ticket#{Id}";
        }

        public Ticket(int id = 0, TicketType ticketType = new TicketType(), double price = 0)
        {
            Id = id;
            Type = ticketType;
            DateOfPurchase = null;
            Price = price;
            OwnerName = null;
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

        public string GetTicketType()
        {
            switch (Type)
            {
                case TicketType.Economy: return "Economy";
                case TicketType.Middle: return "Middle";
                case TicketType.Business: return "Business";
                default: return "";
            }
        }


        public bool IsPurchased() => OwnerName != null;

        public bool CheckOwner(string ownerName)
        {
            if (IsPurchased()) return ownerName == OwnerName;
            else return false;
        }

        public void Purchase(Client cliet)
        {
            cliet.Balance -= Price;
            State = TicketState.Purchased;
            OwnerName = cliet.Username;
            DateOfPurchase = DateTime.Now;
        }
    }
}
