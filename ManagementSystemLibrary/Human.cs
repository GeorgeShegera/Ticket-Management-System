﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Human(string name = "", string surname = "", int age = 0)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
