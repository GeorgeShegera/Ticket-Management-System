using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Client : User
    {
        public double Sum { get; set; } = 0;        
        public Client(string email, string username, string passoword, string name, string surname, DateTime date)
            : base(email, username, passoword, name, surname, date) { }
    }
}
