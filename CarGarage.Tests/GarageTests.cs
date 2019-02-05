using System;
using Xunit;
using System.Collections.Generic;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            var myCars = new Garage();
            // Arrange
            myCars.AddCar();
            // Act
            Assert.NotEmpty(myCars.myGarage);    
            // Assert
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            var myCars = new Garage();
            // Arrange
            myCars.RemoveCar();
            // Act
            Assert.Empty(myCars.myGarage);
            // Assert
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            var CarList = new Garage();
            CarList.myGarage.Add(new Car());
            CarList.myGarage.Add(new Car());
            CarList.myGarage[0].Accelerate();
            CarList.myGarage[1].Accelerate();
            // Arrange
            CarList.FuelAllCars();
            // Act
            Assert.Equal(100, CarList.myGarage[0].FuelLevel);
            // Assert
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
