using System;
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
        public DateTime? DateBirth { get; set; }
        public Human(string name = "", string surname = "", DateTime? date = null)
        {
            Name = name;
            Surname = surname;
            DateBirth = date;
        }
    }
}
