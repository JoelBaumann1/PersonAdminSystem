using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class Person
    {
        public string Firstname { get; }
        public string Surname { get; }

        public Person(string firstname, string surname)
        {
            Firstname = firstname;
            Surname = surname;
        }
        public static int CompareFirstname(Person me, Person other)
        {
            return me.Firstname.CompareTo(other.Firstname);
        }

        public static int CompareSurname(Person me, Person other)
        {
            return me.Surname.CompareTo(other.Surname);
        }
    }
}
