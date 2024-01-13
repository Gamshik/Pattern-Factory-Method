using PatternFactoryMethod.Bases;

namespace PatternFactoryMethod.Entities.Animals
{
    public class Lion : AnimalBase
    {
        public Lion() : base("Lion")
        {
        }

        public override string Eat(FoodBase foodBase)
        {
            return $"Lion eat - {foodBase.Name}";
        }
    }
}