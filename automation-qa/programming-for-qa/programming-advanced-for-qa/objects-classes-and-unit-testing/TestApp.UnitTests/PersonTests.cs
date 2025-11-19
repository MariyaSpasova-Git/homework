using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;
    private List<Person> _persons;
    
    [SetUp]
    public void SetUp()
    {
        _person = new Person();
        _persons = new List<Person>();

        Person firstPerson = new Person();
        firstPerson.Name = "Alice";
        firstPerson.Age = 35;
        firstPerson.Id = "A001";

        Person secondPerson = new Person();
        secondPerson.Name = "Bob";
        secondPerson.Age = 30;
        secondPerson.Id = "B002";

        _persons.Add(firstPerson);
        _persons.Add(secondPerson);
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expected = _persons;
        
        // Act
        List<Person> result = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(result, Has.Count.EqualTo(2));

        for (int i = 0; i < result.Count; i++)
        {
        Assert.That(result[i].Name, Is.EqualTo(expected[i].Name));
        Assert.That(result[i].Id, Is.EqualTo(expected[i].Id));
        Assert.That(result[i].Age, Is.EqualTo(expected[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> persons = new List<Person>();

        Person thirdPerson = new Person();
        thirdPerson.Name = "Pesho";
        thirdPerson.Age = 50;
        thirdPerson.Id = "P003";

        _persons.Add(thirdPerson);

        string expected = $"Bob with ID: B002 is 30 years old.{Environment.NewLine}" +
            $"Alice with ID: A001 is 35 years old.{Environment.NewLine}" +
            "Pesho with ID: P003 is 50 years old.";

        // Act
        string result = _person.GetByAgeAscending(_persons);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
