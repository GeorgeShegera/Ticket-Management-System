using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Client : User
    {
        public Client(string email, string login, string passoword, string name, string surname, int age)
            : base(email, login, passoword, name, surname, age) { }
    }
}
