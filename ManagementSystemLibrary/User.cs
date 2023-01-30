﻿using System;
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
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string email, string login, string password, string name, string surname, int age)
            : base(name, surname, age)
        {
            Email = email;
            Login = login;
            Password = password;
        }
        public User(string login, string password)
            : base()
        {
            Login = login;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            if (obj is User user) return user == this;
            else return false;
        }
        public override int GetHashCode()
        {            
            return (Login, Password).GetHashCode();
        }
        public static bool operator ==(User user1, User user2)
        {
            return user1.Login == user2.Login && user1.Password == user2.Password;
        }
        public static bool operator !=(User user1, User user2)
        {
            return user1.Login != user2.Login || user1.Password != user2.Password;
        }
    }
}
