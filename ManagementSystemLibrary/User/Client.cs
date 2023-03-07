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
        public double Balance { get; set; }
        public Client(string email, string username, string passoword, 
                      string name, string surname, DateTime date, double balance = 0)
            : base(email, username, passoword, name, surname, date) 
        {
            Balance = balance;
        }
    }
}
