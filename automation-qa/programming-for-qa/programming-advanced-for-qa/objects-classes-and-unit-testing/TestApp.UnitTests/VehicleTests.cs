using NUnit.Framework;

using System;
using System.Text;
using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;
    [SetUp]
    public void SetUp()
    {
        _vehicles = new Vehicles();
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[] 
        { 
            "Truck/Volvo/VNL/500",
            "Car/Toyota/Camry/150",
            "Car/Ford/Focus/120" 
        };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Cars:");
        sb.AppendLine("Ford: Focus - 120hp");
        sb.AppendLine("Toyota: Camry - 150hp");
        sb.AppendLine("Trucks:");
        sb.AppendLine("Volvo: VNL - 500kg");

        string expected = sb.ToString().TrimEnd();

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        //Act
        string result = _vehicles.AddAndGetCatalogue(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
