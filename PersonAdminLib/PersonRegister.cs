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

        public int ReadPersonsFromFile(string filename)
        {
            int count = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split('\t');
                personList.Add(new Person(words[0], words[1]));
                count++;
            }
            file.Close();
            return count;
        }
    }
}
