namespace Covariance_and_contravariance_of_delegates
{

    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void SayHello();
    }

    class Dog : Animal
    {
        public override void SayHello()
        {
            Console.WriteLine($"Woof! My name is {Name}.");
        }
    }

    class Cat : Animal
    {
        public override void SayHello()
        {
            Console.WriteLine($"Meow! My name is {Name}.");
        }
    }

    internal class Program
    {
        static void PerformActionOnAnimals(List<Animal> animals, Action<Animal> action)
        {
            foreach (Animal animal in animals)
            {
                action(animal);
            }
        }

        static void Main(string[] args)
        {
            // Создадим список животных
            List<Animal> animals = new List<Animal>
            {
             new Dog { Name = "Buddy" },
             new Cat { Name = "Whiskers" },
              new Dog { Name = "Max" }
             };

            // Создадим экземпляр делегата, который выводит приветствие от животного
            Action<Animal> sayHelloDelegate = animal => animal.SayHello();

            // Применим метод PerformActionOnAnimals для вызова делегата для каждого животного из списка
            PerformActionOnAnimals(animals, sayHelloDelegate);
         Console.ReadLine();
        }
    }
}