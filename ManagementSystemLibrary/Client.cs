using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Client : User
    {
        public Client(string email, string username, string passoword, string name, string surname, DateTime date)
            : base(email, username, passoword, name, surname, date) { }
    }
}
