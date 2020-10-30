using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    class Program
    {
        private static void Main(string[] args)
        {
            //CreateCats();

            //Task01();

            //Task02();

            Task03();

            Console.ReadKey();
        }

        //Homework
        private static void Task03()
        {
            Battery baterry = new Battery("Li-Ion", 4.5, 2550, 4);
            Screen screen = new Screen(33.78, "3200x1800", "IPS sensor display");
            Laptop laptop = new Laptop("Lenovo Yoga 2 Pro", 2259, "Lenovo", baterry, "Intel Core i5-4210U", 8, "Intel HD Graphics 4400", 128, screen);
            Console.WriteLine(laptop.toString());
            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", 2259);
            Console.WriteLine();
            Console.WriteLine(laptop2.toString());
        }

        private static void Task02()
        {
            Person person1 = new Person("John Smith", 22);

            Person person2 = new Person("Jane Smith", 20, "jane@smith.com");

            Person person3 = new Person("Ivan", 20, "my@email");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
        }

        private static void Task01()
        {
            Dog dog = new Dog
            {
                Name = "Sharo",
                Breed = "Street Universal"
            };

            dog.Bark();
        }

        private static void CreateCats()
        {
            Animal animal = new Animal();

            Cat myCat = new Cat("Maria", "Stefania");

            Cat myCat1 = new Cat("Homeless cat");

            Cat myCat2 = new Cat()
            {
                Name = "Maria",
                Owner = "Stefania"
            };

            Console.WriteLine($"Hello {myCat.Name}!");
        }
    }
}
