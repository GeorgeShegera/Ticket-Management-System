﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Trip> GetTrips(string trainName)
            => Trains.Where(x => x.Name == trainName).FirstOrDefault().Trips;

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

        public bool IsTakenUsername(string username) => Users.Any(x => x.Username == username);
        public bool IsTakenTrainName(string name) => Trains.Any(x => x.Name == name);
        public bool IsTakenTripName(string name) => GetTrips().Any(x => x.Name == name);
    }
}
