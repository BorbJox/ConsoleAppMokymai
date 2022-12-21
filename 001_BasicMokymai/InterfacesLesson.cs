using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class LinqPractice
    {
        public static void Run()
        {
            FilesPlayground();

            

        }

        public static void FilesPlayground()
        {
            IEnumerable<string> files = Directory.EnumerateFiles(@"D:\Jox\Desktop");

            IEnumerable<string> txtFiles = files
                .Where(file => file.EndsWith(".jpg"))
                .Select(file => file[(file.LastIndexOf('\\') + 1)..]);

            foreach (string file in txtFiles)
            {
                Console.WriteLine(file);
            }
        }

        public static void PetsPlayground()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Pets = new List<Pet> { new Pet("Aaron", 17), new Pet("Beaver", 2) } });
            people.Add(new Person { Pets = new List<Pet> { new Pet("Anne", 5), new Pet("Kitty", 8), new Pet("Robert", 7) } });
            people.Add(new Person { Pets = new List<Pet> { new Pet("Agnes", 1) } });
            people.Add(new Person { Pets = new List<Pet> { new Pet("Slime", 12), new Pet("Woofer", 16) } });
            people.Add(new Person { Pets = new List<Pet> { new Pet("Chirpy", 2) } });

            IEnumerable<Pet> pets = people.SelectMany(people => people.Pets);

            foreach (Pet pet in pets)
            {
                Console.WriteLine($"Pet: {pet.Name} age {pet.Age}");
            }

            IEnumerable<Pet> aPets = people.SelectMany(people => people.Pets).Where(pet => pet.Name[0] == 'A');

            foreach (Pet pet in aPets)
            {
                Console.WriteLine($"A Pet: {pet.Name} age {pet.Age}");
            }

            IEnumerable<Pet> aFivePets = people.SelectMany(people => people.Pets).Where(pet => pet.Name[0] == 'A').Where(pet => pet.Age > 5);

            foreach (Pet pet in aFivePets)
            {
                Console.WriteLine($"A Pet 5+: {pet.Name} age {pet.Age}");
            }
        }
    }

    internal class Person
    {
        public Person()
        {
            Pets = new List<Pet>();
        }
        public List<Pet> Pets { get; set; }
    }

    internal class Pet
    {
        public Pet(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
