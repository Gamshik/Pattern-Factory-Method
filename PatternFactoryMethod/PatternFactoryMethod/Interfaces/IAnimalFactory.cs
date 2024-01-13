using PatternFactoryMethod.Bases;

namespace PatternFactoryMethod.Interfaces
{
    public interface IAnimalFactory
    {
        public AnimalBase CreateAnimal();
    }
}
