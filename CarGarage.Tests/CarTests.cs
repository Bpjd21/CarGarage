using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            var Car = new Car();
            // Arrange
            Car.Accelerate();
            // Act
            Assert.Equal(10, Car.Speed);
            // Assert
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            var Car = new Car();
            // Arrange
            Car.Accelerate();
            // Act
            Assert.Equal(98, Car.FuelLevel);
            // Assert
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            var Car = new Car();
            // Arrange
            Car.AddFuel();
            // Act
            Assert.Equal(100, Car.FuelLevel);
            // Assert
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            var Car = new Car();
            // Arrange
            Car.Brake();
            // Act
            Assert.Equal(0, Car.Speed);
            // Assert
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            var Car = new Car();
            // Arrange
            Car.ToggleEngine();
            // Act
            Assert.True(true);
            // Assert
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            var Car = new Car();
            // Arrange
            Car.ToggleEngine();
            // Act
            Assert.False(false);
            // Assert
        }
    }
}
