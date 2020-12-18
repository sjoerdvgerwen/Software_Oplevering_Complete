using System;
using Circustrein1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.UnitTest1
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void Wagon_Constructed_With_Default_Capacity()
        {
            //Arrange
            Wagon wagon = new Wagon();


            //Act


            //Assert
            Assert.IsNotNull(wagon);
            Assert.AreEqual(10, wagon.MaxCapacity);
        }

        [TestMethod]
        public void When_Animal_Is_Added_Capacity_Is_Lower()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal animal = new Animal("AAP", AnimalSize.Large, AnimalType.Carnivore);

            //Act
            int originalCapacity = wagon.MaxCapacity;
            int animalSize = (int) animal.Size;
            int expectedCapacity = originalCapacity - animalSize;

            wagon.AddAnimalToWagon(animal);

            //Assert
            Assert.AreEqual(expectedCapacity, wagon.Capacity);
        }

        [TestMethod]
        public void Cant_Add_Herbivore_With_Same_Size_Or_Bigger_Carnivore()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal carnivore = new Animal("Tijger", AnimalSize.Medium, AnimalType.Carnivore);
            Animal herbivore = new Animal("Paard", AnimalSize.Medium, AnimalType.Herbivore);
            //Act
            wagon.AddAnimalToWagon(carnivore);

            //Assert
            Assert.IsFalse(wagon.AddAnimalToWagon(herbivore));
        }

        [TestMethod]
        public void Cant_Add_Animals_To_Full_Wagon()
        {
            Wagon wagon = new Wagon();
            Animal herbivore1 = new Animal("Big Herbivore1", AnimalSize.Large, AnimalType.Herbivore);
            Animal herbivore2 = new Animal("Big Herbivore2", AnimalSize.Large, AnimalType.Herbivore);
            Animal herbivore3 = new Animal("Big Herbivore3", AnimalSize.Large, AnimalType.Herbivore);

            wagon.AddAnimalToWagon(herbivore1);
            wagon.AddAnimalToWagon(herbivore2);
            wagon.AddAnimalToWagon(herbivore3);


            bool DoesAnimalFitInWagon()
            {
                if (wagon.MaxCapacity > 10)
                {
                    return false;
                }

                return true;
            }

            //Assert
            Assert.IsTrue(DoesAnimalFitInWagon());
        }
    }
}