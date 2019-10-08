using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

//https://docs.microsoft.com/ru-ru/dotnet/csharp/linq/perform-inner-joins
class Solution
{
    static void Main()
    {
        Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
        Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
        Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
        Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
        Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

        Pet barley = new Pet { Name = "Barley", Owner = terry };
        Pet boots = new Pet { Name = "Boots", Owner = terry };
        Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
        Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
        Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

        // Create two lists.
        List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui };
        List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

        // Create a collection of person-pet pairs. Each element in the collection
        // is an anonymous type containing both the person's name and their pet's name.
        var query = from person in people
                    join pet in pets on person equals pet.Owner
                    select new { OwnerName = person.FirstName, PetName = pet.Name };

        foreach (var ownerAndPet in query)
        {
            Console.WriteLine(ownerAndPet.PetName +  " is owned by " + ownerAndPet.OwnerName);
        }

        Console.WriteLine( "query.Count = " + query.Count());
        Console.WriteLine(query.ElementAt(0).OwnerName);

        Console.ReadLine();
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Pet
{
    public string Name { get; set; }
    public Person Owner { get; set; }
}
