using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using tim_yppgift_sokningar;

class Program
{
    
    static Person BinarySearch(List<Person> personer, int personnr)
    {
        

    }

    static void Main(string[] args)
    {
        List<Person>personlista = new List<Person>();
        {
           personlista.Add(new Person(1001, "Dragan"));
           personlista.Add(new Person(1002, "Bob"));
           personlista.Add(new Person(1003, "Bengan"));
           personlista.Add(new Person(1004, "David"));
           personlista.Add(new Person(1005, "Dalton"));
        };

        int söktPersonnr = 1003;
        Person person = BinarySearch(personlista, söktPersonnr);

        if (person != null)
        {
            Console.WriteLine($"Hittade {person.Namn} med personnr {person.Personnr}");
        }
        else
        {
            Console.WriteLine($"Person med personnr {söktPersonnr} finns inte.");
        }
        
    }
}
