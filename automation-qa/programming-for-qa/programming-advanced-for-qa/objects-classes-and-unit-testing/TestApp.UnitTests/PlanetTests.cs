using NUnit.Framework;

using System;
using System.Text;
using System.Xml.Linq;

namespace TestApp.UnitTests;

public class PlanetTests
{
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        Planet earth = new Planet("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double resultGravity = earth.CalculateGravity(mass);

        // Assert
        Assert.That(resultGravity, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet earth = new Planet("Earth", 12742, 149600000, 1);

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Planet: Earth");
        sb.AppendLine($"Diameter: 12742 km");
        sb.AppendLine($"Distance from the Sun: 149600000 km");
        sb.AppendLine($"Number of Moons: 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = earth.GetPlanetInfo();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
