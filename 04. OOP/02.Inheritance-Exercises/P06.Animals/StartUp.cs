using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input = "";
            string gender = "";
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();

                if (string.IsNullOrEmpty(animalInfo[0]) || string.IsNullOrEmpty(animalInfo[1]))
                {
                    System.Console.WriteLine("Invalid input");
                    continue;
                }
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                if (age < 0)
                {
                    System.Console.WriteLine("Invalid input!");
                    continue;
                }
                if ((input == "Cat" || input == "Dog" || input == "Frog") && animalInfo.Length < 3)
                {
                    System.Console.WriteLine("Invalid input");
                    continue;
                }

                if (animalInfo.Length > 2)
                {
                    gender = animalInfo[2];
                }



                switch (input)
                {
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;
                    case "Kitten":
                        Kitten kitty = new Kitten(name, age);
                        animals.Add(kitty);
                        break;
                    case "Tomcat":
                        Tomcat tom = new Tomcat(name, age);
                        animals.Add(tom);
                        break;
                }
            }

            System.Console.WriteLine(string.Join("\r\n", animals));
        }
    }
}