using PatternFactoryMethod.Bases;
using PatternFactoryMethod.Creators;
using PatternFactoryMethod.Entities.Foods;
using PatternFactoryMethod.Interfaces;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory lionFactory = new LionCreator();
            AnimalBase lion = lionFactory.CreateAnimal();
            Console.WriteLine(lion.Eat(new Meat()));

            IAnimalFactory elephantFactory = new ElephantCreator();
            AnimalBase elephant = elephantFactory.CreateAnimal();
            Console.WriteLine(elephant.Eat(new Grass()));
        }
    }
}
