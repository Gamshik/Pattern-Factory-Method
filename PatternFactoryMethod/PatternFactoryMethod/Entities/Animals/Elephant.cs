using PatternFactoryMethod.Bases;

namespace PatternFactoryMethod.Entities.Animals
{
    public class Elephant : AnimalBase
    {
        public Elephant() : base("Elephant")
        {
        }

        public override string Eat(FoodBase foodBase)
        {
            return $"Elephant eat - {foodBase.Name}";
        }
    }
}
