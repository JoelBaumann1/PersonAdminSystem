using PersonAdminLib;
using System.Reflection;    
namespace PersonAdmin
{
    internal class PersonAdmin
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"My first C# Program: {Assembly.GetExecutingAssembly().GetName().Version}");
            Person person = new Person("Jack", "Smith");
            Console.WriteLine($"Firstname: {person.Firstname} Lastname: {person.Surname}");

            double e = 2.718281828459045; double d = e; object o1 = d; object o2 = e; Console.WriteLine(d == e); Console.WriteLine(o1 == o2);

            var personRegister = new PersonRegister();
            System.Console.WriteLine($"Number of persons: {personRegister.ReadPersonsFromFile("persons.txt")}");
            //personRegister.personList.Add(person);
            //personRegister.personList.Add(new Person("John", "Doe"));
            //personRegister.personList.Add(new Person("Jane", "Doee"));
            //personRegister.personList.Add(new Person("Jack", "Doeee"));
            Console.WriteLine($"Person: {personRegister[0].Firstname} {personRegister[0].Surname}");
            
            Console.WriteLine("Person: {0} {1}", personRegister[personRegister.Count - 1].Firstname, personRegister[personRegister.Count - 1].Surname);
        }
    }
}