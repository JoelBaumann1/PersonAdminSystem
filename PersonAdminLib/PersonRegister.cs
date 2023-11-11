using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        private List<Person> personList;
        public PersonRegister this[int i]
        {
            get { personList != null? return pers[i]; : return -1 }
            
        }
    }
}
