using System;
using zoo;

namespace StartOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Program...");
            Animal my_animal = new Animal();//creates an instance of type "Animal"
            my_animal.ToString();
            Console.WriteLine(my_animal.ToString());
            Console.WriteLine("The Animal is: " + my_animal.sleep());
            Dog my_dog = new Dog();//bring a Dog to life
            Console.WriteLine("This Dog is: " +my_dog.sleep());
            Console.WriteLine("Ending Program...");
        }
    }
}
