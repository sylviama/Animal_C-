﻿using System;
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
            Console.WriteLine("The Animal dance: "+ my_animal.dance());

            Dog my_dog = new Dog();//bring a Dog to life
            Console.WriteLine("This Dog is: " +my_dog.sleep());
            Console.WriteLine("Dog dance: "+ my_dog.dance());

            Cat my_cat= new Cat();
            Console.WriteLine("cat meow with Integar:" + my_cat.meow(-3));
            Console.WriteLine("Cat meow without: "+ my_cat.meow());

            Console.WriteLine(my_cat.neowThenPurr());

            


            Console.WriteLine("Ending Program..."); 
        }
    }
}
