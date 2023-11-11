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

        }
    }
}