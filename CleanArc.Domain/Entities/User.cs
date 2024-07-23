using CleanArc.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities
{
    public  class User
    {
        public User(string firstName, string lastName, Phonebook phonebook)
        {
            FirstName = firstName;
            LastName = lastName;
            Phonebook = phonebook;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Phonebook Phonebook { get; private set; }

    }
}
