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
    }
}
