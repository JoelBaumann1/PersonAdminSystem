using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdminLib 
{ 
    public class PersonRegister
    {
        private List<Person> personList = new List<Person>();

        public delegate void PersonAddedHandler(object source, PersonEventArgs args);
        public event PersonAddedHandler PersonAddedEvent;

        public PersonRegister()
        {
            InitPersons();
        }
        private void InitPersons()
        {
            this.Add(new Person("James", "Dean"));
            this.Add(new Person("Sean", "Connery"));
            this.Add(new Person("Jeremey", "Black"));
            this.Add(new Person("Andy", "Warhol"));
        }

        public List<Person> Persons {
            get { return personList; } 
        }

        public IEnumerable<string?> GetPersons() {
            return personList.GetItemsAsString(); 
        }

        public Person this[int i]
        {
            get { return personList[i]; }
            
        }
        public int Count
        {
            get { return personList.Count; }
        }
        public int Add(Person newPerson)
        {
            if(newPerson == null)
            {
                return personList.Count;
            }
            personList.Add(newPerson);
            PersonAddedEvent?.Invoke(this, new PersonEventArgs(newPerson));
            return personList.Count;
        }

        public Person FindPerson(string surname)
        {
            foreach (var p in personList) if (p.Surname == surname.Trim()) return p;
            return null;
        }


        public Person? FindPerson(Predicate<Person> match)
        {
            return personList.Find(match);
        }
        public void Sort(Comparison<Person> comparer)
        {
            personList.Sort(comparer);
        }
        public int ReadPersonsFromFile(string filename)
        {
            int count = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split('\t');
                this.Add(new Person(words[0], words[1]));
                count++;
            }
            file.Close();
            return count;
        }

        public void PrintPersons()
        {
            foreach (var p in Persons)
                Console.WriteLine($"{p.Surname}, {p.Firstname}");
        }
    }
}
