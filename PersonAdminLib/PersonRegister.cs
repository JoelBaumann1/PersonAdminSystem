using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        public List<Person> personList = new List<Person>();
        public Person this[int i]
        {
            get { return personList[i]; }
            
        }
        public int Count
        {
            get { return personList.Count; }
        }
    }
}
