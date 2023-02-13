using Newtonsoft.Json;
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
        public List<Trip> Trips { get; set; }
        public List<Train> Trains { get; set; }
        public List<User> Users { get; set; } 

        public DataBase() 
        {
            Trips = new List<Trip>();
            Trains = new List<Train>();
            Users = new List<User>();
        }

        private void Save()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(this, settings);
            using (FileStream stream = new FileStream("DataBase.json", FileMode.Open))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    writer.WriteLine(json);
            }
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            Save();
        }
        public bool IsTakenUsername(string username) => Users.Any(x => x.Username == username);
        public void SaveUser(User user)
        {
            for (int i = 0; i < Users.Count; i++)
                if (Users[i].Username == user.Username) Users[i] = user;
            Save();
        }
    }
}
