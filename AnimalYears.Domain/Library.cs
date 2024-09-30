namespace AnimalYears.Domain
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Cat : Animal
    {

    }
    public class Dog : Animal
    {

    }
}
