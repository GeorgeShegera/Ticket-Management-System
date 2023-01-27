using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagementSystemLibrary
{
    public class User : Human
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string email, string login, string password, string name, string surname, int age)
            : base(name, surname, age)
        {
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
