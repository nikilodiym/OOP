using OOP.Classes;
using System.Security.Cryptography;


namespace OOP
{
    internal class Program
    {
        private const int V = 5;

        private static void editPersonName(ref Person person, string name, string age)
        {
            person.Name = name;
            person.Age = V;
        }
        static void Main(string[] args)
        {
            Person person = new Person(name: "Bob", age: 30, 
                dateOfBirthday: new DateOfBirthday(day: 03, month: 12, year: 2000),
                adressInfo: new AdressInfo(street: "Wall Street", city: "New York", region: "-", country: "USA", postalCode: 00000));

            System.Console.WriteLine(person);
            editPersonName(ref person, "Alice", "12");
            System.Console.WriteLine(person);
        }
    }
}
