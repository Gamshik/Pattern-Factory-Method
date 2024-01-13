using PatternFactoryMethod.Bases;
using PatternFactoryMethod.Entities.Animals;
using PatternFactoryMethod.Interfaces;

namespace PatternFactoryMethod.Creators
{
    public class ElephantCreator : IAnimalFactory
    {
        public AnimalBase CreateAnimal()
        {
            return new Elephant();
        }
    }
}
