using Assignment_3_Lexicon;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assignment 3a!");

            //test case 1
            try
            {
                //initialize person object
                Person person = new Person();

                Console.WriteLine("Please Enter Age.");
                //reads age value
                var age = Console.ReadLine();
                person.Age = Convert.ToInt32(age);

                Console.WriteLine("Please Enter First Name.");
                //reads age value
                var fName = Console.ReadLine();
                person.FName = fName;

                Console.WriteLine("Please Enter Last Name.");
                //reads age value
                var lName = Console.ReadLine();
                person.LName = lName;

                Console.WriteLine("Please Enter Height.");
                //reads height value
                var height = Console.ReadLine();
                person.Height = Convert.ToDouble(height);

                Console.WriteLine("Please Enter Weight.");
                //reads age value
                var weight = Console.ReadLine();
                person.Weight = Convert.ToDouble(weight);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
            }

            //test case 2
            try
            {
                //initialize person object
                Person person = new Person();

                Console.WriteLine("Please Enter Age.");
                //reads age value
                var ageValue = Console.ReadLine();
                var age = Convert.ToInt32(ageValue);

                Console.WriteLine("Please Enter First Name.");
                //reads age value
                var fName = Console.ReadLine();

                Console.WriteLine("Please Enter Last Name.");
                //reads age value
                var lName = Console.ReadLine();

                Console.WriteLine("Please Enter Height.");
                //reads height value
                var heightValue = Console.ReadLine();
                var height = Convert.ToDouble(heightValue);

                Console.WriteLine("Please Enter Weight.");
                //reads age value
                var weightValue = Console.ReadLine();
                var weight = Convert.ToDouble(weightValue);

                PersonHandler personHandler = new PersonHandler();
                PersonHandler.CreatePerson(age, fName, lName, height, weight);

                Console.WriteLine("Person created.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
            }
        }
    }
}
