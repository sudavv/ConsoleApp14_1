using System;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Введите название животного: кошка или собака ");
            string animal = Console.ReadLine();

            if (animal == "кошка")            
            {
                Cat cat = new Cat(animal);
                cat.ShowInfo();
            }
            else if (animal == "собака")
            {                
                Dog dog = new Dog(animal);
                dog.ShowInfo();
            }
            else
            {
                Console.WriteLine("Выберите между кошкой и собакой");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        public abstract class Animal
        {
            public Animal(string Name)
            {
                this.Name = Name;               
            }

            public abstract string Name { get; set; }
            public abstract string Voice { get; set; }

            public abstract string Say();

            public string ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
                return null;
            }
        }

        public class Cat : Animal
        {
            public Cat(string Name) : base(Name) { }
            public override string Voice { get; set;}

            public override string Name { get; set; }

            public override string Say()
            {
                Console.WriteLine("Мяу");
                return null;
            }
        }
        public class Dog : Animal
        {
            public Dog(string Name) : base(Name) { }
        
            public override string Voice { get; set; }

            public override string Name { get; set; }

            public override string Say()
            {
                Console.WriteLine("Гав");
                return null;
            }
        }
    }
}
