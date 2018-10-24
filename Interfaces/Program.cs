using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));

            dogs[0].HairStyle = "short";
            dogs[1].HairStyle = "long";
            dogs[2].HairStyle = "medium";
            
            dogs.Sort();
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.HairStyle);
                Console.ReadKey();
            }
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Describe());
                Console.ReadKey();
            }

            
        }
    }

    interface IAnimal
    {
        string Describe();

        string Name
        {
            get;
            set;
        }
    }

    interface IHair
    {
        int HairLength();

        string HairStyle
        {
            get;
            set;
        }
    }

    class Dog : IAnimal, IHair, IComparable
    {
        private string name;
        private string hairStyle;

        public Dog(string name)
        {
            this.Name = name;
        }

        public string HairStyle
        {
            get { return hairStyle; }
            set { hairStyle = value; }
        }
           

        public string Describe()
        {
            return "Hello, I'm a dog and my name is " + this.Name;
        }
        public int CompareHair(object obj)
        {

            if (obj is IHair)
            {
                return this.hairStyle.CompareTo((obj as IHair).HairStyle);
            }
            return 0;
        }
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
            {
                return this.name.CompareTo((obj as IAnimal).Name);
            }
                return 0;
        }

        

        public int HairLength()
        {
            return 20;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
