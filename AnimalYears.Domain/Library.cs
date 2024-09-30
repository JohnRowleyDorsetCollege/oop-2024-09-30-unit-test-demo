namespace AnimalYears.Domain
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract int AgeInHumanYears();
    }

    public class Cat : Animal
    {
        public override int AgeInHumanYears() { return Age * 5; }    
    }
    public class Dog : Animal
    {
        public override int AgeInHumanYears() { return Age * 7; }
    }
}
