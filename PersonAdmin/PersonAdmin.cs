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
            Console.WriteLine($"Person: {personRegister[0].Firstname} {personRegister[0].Surname}");
        }
    }
}