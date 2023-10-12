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

        /// <summary>
        /// Напишите абстрактный класс Animal, который содержит свойство Name и абстрактный метод void SayHello(). Затем напишите классы Dog и Cat, которые наследуются от класса Animal и реализуют метод SayHello() так, чтобы он выводил на консоль приветствие от животного с его именем. 
        /// Затем напишите метод, который принимает на вход список животных типа List<Animal> и делегат типа Action<Animal> и вызывает этот делегат для каждого животного из списка.
        /// Продемонстрируйте использование ковариантности и контрвариантности при передаче различных делегатов в этот метод.
        /// </summary>
        /// <param name="args"></param>
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