using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Base
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }

    public class WildAnimal : Animal
    {
        public WildAnimal(string name) : base(name)
        {
            Console.WriteLine(name);
        }
    }

    public class DomesticAnimal : Animal
    {
        public DomesticAnimal(string name) : base(name)
        {
            Console.WriteLine(name);
          
        }
    }
    class Driver 
    {
        static void Main(string[] args)
        {
            WildAnimal wild = new WildAnimal("Tiger");
            DomesticAnimal dom = new DomesticAnimal("Dog");

        }
    }
}
