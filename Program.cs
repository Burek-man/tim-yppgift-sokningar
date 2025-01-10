// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    // Binärsökning på en lista av personer, söker efter personnummer
    static Person BinarySearch(List<Person> personer, int personnr)
    {
        int left = 0;
        int right = personer.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Hämta person från listan
            Person midPerson = personer[mid];

            // Jämför personnummer
            if (midPerson.Personnr == personnr)
            {
                return midPerson; // Hittade personen
            }
            else if (midPerson.Personnr < personnr)
            {
                left = mid + 1; // Sök i högra delen
            }
            else
            {
                right = mid - 1; // Sök i vänstra delen
            }
        }

        return null; // Om personen inte finns i listan
    }

    static void Main()
    {
        // Skapa en lista med personer
        List<Person> personer = new List<Person>
        {
            new Person(1001, "Alice"),
            new Person(1002, "Bob"),
            new Person(1003, "Charlie"),
            new Person(1004, "David"),
            new Person(1005, "Eve")
        };

        // Exempel på att söka efter en person
        int söktPersonnr = 1003;
        Person person = BinarySearch(personer, söktPersonnr);

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
if