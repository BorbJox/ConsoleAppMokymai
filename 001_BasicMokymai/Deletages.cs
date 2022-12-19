using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class Deletages
    {
        private delegate bool Filter(Persona person);

        public static void Run()
        {
            List<Persona> list = new List<Persona>();
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(new Persona(GenerateName(), random.Next(100)));
            }

            Filter checkChild = delegate (Persona person)
            {
                return person.age < 18;
            };

            Filter checkAdult = p => p.age >= 18;

            DisplayPeople("Children: ", list, checkChild);
            DisplayPeople("Adults: ", list, checkAdult);
            DisplayPeople("Seniors: ", list, IsSenior);
        }

        private static void DisplayPeople(string title, List<Persona> people, Filter filter)
        {
            int count = 0;
            foreach (Persona p in people)
            {
                if (filter(p))
                {
                    count++;
                }
            }
            Console.WriteLine(title + count);
        }

        private static bool IsChild(Persona person)
        {
            return person.age < 18;
        }

        private static bool IsAdult(Persona person)
        {
            return person.age >= 18;
        }

        private static bool IsSenior(Persona person)
        {
            return person.age >= 65;
        }

        private static string GenerateName()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
}

    internal class Persona
    {
        public Persona(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;
    }
}
