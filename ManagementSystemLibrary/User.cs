using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace ManagementSystemLibrary
{
    public class User : Human
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string email, string username, string password, string name, string surname, DateTime date)
            : base(name, surname, date)
        {
            Email = email;
            Username = username;
            Password = password;
        }
        public User(string username, string password)
            : base()
        {
            Username = username;
            Password = password;
        }
        public User() : base() { }
        public override bool Equals(object obj)
        {
            if (obj is User user) return user == this;
            else return false;
        }
        public override int GetHashCode()
        {            
            return (Username, Password).GetHashCode();
        }
        public static bool operator ==(User user1, User user2)
        {
            return user1.Username == user2.Username && user1.Password == user2.Password;
        }
        public static bool operator !=(User user1, User user2)
        {
            return user1.Username != user2.Username || user1.Password != user2.Password;
        }
    }
}
