namespace PatternFactoryMethod.Bases
{
    public abstract class FoodBase
    {
        public string Name { get; }
        public FoodBase(string name)
        {
            Name = name;
        }
    }
}