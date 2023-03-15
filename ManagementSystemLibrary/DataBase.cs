using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ManagementSystemLibrary
{
    public class DataBase
    {
        public List<Train> Trains { get; set; }
        public List<User> Users { get; set; }

        public DataBase()
        {
            Trains = new List<Train>();
            Users = new List<User>();
        }

        public void Save()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(this, settings);
            using (FileStream stream = new FileStream("DataBase.json", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    writer.WriteLine(json);
            }
        }

        public User GetUser(string username)
            => Users.Where(x => x.Username == username).FirstOrDefault();

        public void AddUser(User user)
        {
            Users.Add(user);
            Save();
        }

        public void AddTrain(Train train)
        {
            Trains.Add(train);
            Save();
        }

        public List<Trip> GetUpcomingTrips(string trainName)
            => Trains.Where(x => x.Name == trainName).FirstOrDefault().Trips.Where(x => x.State == TripState.Upcoming).ToList();

        public List<Trip> GetTrips()
        {
            List<Trip> trips = new List<Trip>();
            foreach (Train train in Trains)
            {
                trips.AddRange(train.Trips);
            }
            return trips;
        }

        public List<Trip> GetCompletedTrips()
        {
            List<Trip> trips = new List<Trip>();
            foreach (Train train in Trains)
                trips.AddRange(train.Trips.Where(x => x.State != TripState.Upcoming).ToList());
            return trips;
        }

        public List<Ticket> GetTickets(string username)
        {
            List<Ticket> tickets = new List<Ticket>();
            List<Trip> trips = GetTrips();
            foreach (Trip trip in trips)
                tickets.AddRange(trip.Tickets.Where(x => x.CheckOwner(username)));
            return tickets;
        }

        public List<Ticket> GetTickets()
        {
            List<Trip> trips = GetTrips();
            List<Ticket> tickets = new List<Ticket>();
            foreach (Trip trip in trips)
                tickets.AddRange(trip.Tickets);
            return tickets;
        }

        public bool IsTakenUsername(string username) => Users.Any(x => x.Username == username);
        public bool IsTakenEmail(string email) => Users.Any(x => x.Email == email);
        public bool IsTakenTrainName(string name) => Trains.Any(x => x.Name == name);
        public bool IsTakenTripName(string name) => GetTrips().Any(x => x.Name == name);

        public void ChangeTicketState(Ticket ticket, TicketState newState)
        {
            if (ticket.State == TicketState.Closed || ticket.State == TicketState.Canceled) return;
            else if (ticket.State == TicketState.Purchased && newState == TicketState.Canceled)
            {
                Client client = (Client)Users.FirstOrDefault(x => x.Username == ticket.OwnerName);
                client.Balance += ticket.Price;
            }
            ticket.State = newState;
        }

        public void ChangeTripState(Trip trip, TripState tripState)
        {
            trip.State = tripState;
            foreach (Ticket ticket in trip.Tickets)
            {
                TicketState ticketState = new TicketState();
                switch (tripState)
                {
                    case TripState.Canceled:
                        ticketState = TicketState.Canceled;
                        break;
                    case TripState.Complete:
                        ticketState = TicketState.Closed;
                        break;
                    case TripState.Upcoming:
                        ticketState = TicketState.New;
                        break;
                }
                ChangeTicketState(ticket, ticketState);
            }
        }

        public void ChangeTrainState(Train train, TrainState trainState)
        {
            train.State = trainState;
            if (trainState == TrainState.Available) return;
            foreach (Trip trip in train.Trips)
                ChangeTripState(trip, TripState.Canceled);
        }

        public void RefreshTrips()
        {
            List<Trip> trips = GetTrips();
            foreach (Trip trip in trips)
            {
                if (trip.ArrivalDate <= DateTime.Now)
                    ChangeTripState(trip, TripState.Complete);
            }
        }
    }
}
