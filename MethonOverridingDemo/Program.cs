using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethonOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Abel",
                LastName = "Donny",
                Email = "abeldonny@mail.com"
            };

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
