using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Animal
    {
        public string Name;
        public string Type;
        public int Age;

        public Animal(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public void ReadAllAnimalInfo()
        {
            Name = ReadName();
            Type = ReadType();
            Age = ReadAge();
        }

        public string ReadName()
        {
            Console.WriteLine("Hva heter dyret?");
            var input = Console.ReadLine();
            return input;
        }

        public string ReadType()
        {
            Console.WriteLine("Hva slags dyr er det?");
            var input = Console.ReadLine();
            return input;
        }

        public int ReadAge()
        {
            Console.WriteLine("Hvor gammel er dyret?");
            var input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {Name}\nType: {Type}\nAlder: {Age}");
        }
    }
}
