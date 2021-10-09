using System;
using System.Collections.Generic;
using System.Text;

namespace Sale_Mini_Project.Entities
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer() { }

        public Customer(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + " " + "(" + BirthDate.ToString() + ")" + " - " + Email; 
        }
    }
}
