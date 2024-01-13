namespace PatternFactoryMethod.Bases
{
    public abstract class AnimalBase
    {
        public string Name { get; }
        public AnimalBase(string name)
        {
            Name = name;
        }
        public abstract string Eat(FoodBase foodBase);
    }
}