using PatternFactoryMethod.Bases;
using PatternFactoryMethod.Entities.Animals;
using PatternFactoryMethod.Interfaces;

namespace PatternFactoryMethod.Creators
{
    public class LionCreator : IAnimalFactory
    {
        public AnimalBase CreateAnimal()
        {
            return new Lion();
        }
    }
}
