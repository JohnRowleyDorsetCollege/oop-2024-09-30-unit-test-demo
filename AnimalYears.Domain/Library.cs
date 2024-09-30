namespace AnimalYears.Domain
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract int AgeInAnimalYears();
    }

    public class Cat : Animal
    {
        public override int AgeInAnimalYears() { 
            
            return Age * 0; 
        
        
        }    
    }
    public class Dog : Animal
    {
        public override int AgeInAnimalYears() { return Age * 7; }
    }
}
