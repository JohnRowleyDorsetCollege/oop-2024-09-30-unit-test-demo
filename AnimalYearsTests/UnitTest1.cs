using AnimalYears.Domain;

namespace AnimalYearsTests
{
    public class AnimalYearsUnitTests
    {
        [Fact]
        public void DogYearsShouldCalculateCorrectly()
        {
            int dogAge = 5;
            int ExpectedDogYears = 35; /// 5 * 7;

            Dog d = new Dog() { Age = 5 };



            Assert.Equal(ExpectedDogYears, d.AgeInAnimalYears());


        }
    }
}