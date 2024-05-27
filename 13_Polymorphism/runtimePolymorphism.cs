using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2runtimePolymorphism
{
    // Write a program on Runtime polymorphism in c#
    class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog : Animal
    {
        // Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    }

    class Cat : Animal
    {
        // Overriding the base class method
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Calling the overridden methods
            myDog.MakeSound(); // Output: The dog barks
            myCat.MakeSound(); // Output: The cat meows

            // Demonstrating polymorphism
            Animal myAnimal;

            myAnimal = new Dog();
            myAnimal.MakeSound(); // Output: The dog barks

            myAnimal = new Cat();
            myAnimal.MakeSound(); // Output: The cat meows
            Console.ReadKey();
        }
    }
}
