using NivEm.Domain.Base;
using Xunit;

namespace NivEm.Domain.Tests
{
    public class NaturalPersonTests
    {
        [Fact]
        public void GetFullName_ReturnsCorrectFullName()
        {
            //Arange
            var naturalPerson = new NaturalPerson();
            naturalPerson.FirstName = "Nome";
            naturalPerson.LastName = "Teste";

            //Act
            var fullName = naturalPerson.GetFullName();

            //Assert
            Assert.Equal("Nome Teste", fullName);
        }
        
        [Fact]
        public void GetAge_ReturnsCorrectAge()
        {
            //Arrange
            var naturalPerson = new NaturalPerson();
            naturalPerson.BirthDate = System.DateTime.Now.AddYears(-20);

            //Act
            var age = naturalPerson.GetAge();

            //Assert
            Assert.Equal(20, age);
        }
    }
}