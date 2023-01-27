using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Administrator : User
    {
        public Administrator(string email, string login, string password, string name, string surname, int age)
            : base(email, login, password, name, surname, age) { }
    }
}
