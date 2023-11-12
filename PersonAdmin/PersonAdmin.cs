using PersonAdminLib;
using System.Reflection;
using System.Text;

namespace PersonAdmin
{
    internal class PersonAdmin
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"My first C# Program: {Assembly.GetExecutingAssembly().GetName().Version}");

            var personRegister = new PersonRegister();
            personRegister.PersonAddedEvent += WriteNewPersonToFile;
            personRegister.PersonAddedEvent += WriteNewPersonToConsole;


            System.Console.WriteLine($"Number of persons: {personRegister.ReadPersonsFromFile("persons.txt")}");

            Console.WriteLine($"Person: {personRegister[0].Firstname} {personRegister[0].Surname}");
            
            Console.WriteLine("Person: {0} {1}", personRegister[personRegister.Count - 1].Firstname, personRegister[personRegister.Count - 1].Surname);

        
            personRegister.PrintPersons();

            personRegister.Sort(Person.CompareFirstname);
            personRegister.PrintPersons();

            personRegister.Sort(Person.CompareSurname); 
            personRegister.PrintPersons();

            Person p = personRegister.FindPerson(ContainsFirstAndLast);

            Console.WriteLine($"found: {searchChar} in {p.Surname} {p.Firstname}");


        }

        static void WriteNewPersonToConsole(object source, PersonEventArgs args)
        {
            System.Console.WriteLine($"New person: {args.NewPerson.Firstname} {args.NewPerson.Surname}");
        }

        static void WriteNewPersonToFile(object source, PersonEventArgs args)
        {
         

            File.AppendAllText("log.txt", $"\n {DateTime.Now} New person log: {args.NewPerson.Firstname} {args.NewPerson.Surname}");
        }
        private static char searchChar = 'a';
        private static bool ContainsFirstAndLast(Person p)
        {
            return p.Firstname.Contains(searchChar) && p.Surname.Contains(searchChar);
        }
      
    }
}