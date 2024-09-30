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

        [Fact]
        public void CatYearsShouldCalculateCorrectly()
        {
            int catAge = 1;
            Cat c = new Cat() { Age = 1 };

            int expectedCatAge = 15;
            Assert.Equal(expectedCatAge, c.AgeInAnimalYears());


            //Cat c2 = new Cat() { Age = 2 };
            //int expectedCatAge2 = 24;
            //Assert.Equal(expectedCatAge2, c2.AgeInAnimalYears());

            //Cat c3 = new Cat() { Age = 3 };
            //int expectedCatAge3 = 28;
            //Assert.Equal(expectedCatAge3, c3.AgeInAnimalYears());

            //Cat c4 = new Cat() { Age = 4 };
            //int expectedCatAge4 = 32;
            //Assert.Equal(expectedCatAge4, c4.AgeInAnimalYears());



        }
    }
}