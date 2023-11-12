using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class PersonEventArgs : EventArgs
    {
        public Person NewPerson { get; }

        public PersonEventArgs(Person person)
        {
            NewPerson = person;
        }

    }
}
