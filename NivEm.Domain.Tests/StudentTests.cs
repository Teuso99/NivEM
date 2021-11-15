using NivEm.Domain.Entities;
using Xunit;

namespace NivEm.Domain.Tests
{
    public class StudentTests
    {
        [Fact]
        public void GetFullName_ReturnsCorrectFullName()
        {
            //Arange
            var student = new Student();
            student.FirstName = "Nome";
            student.LastName = "Teste";

            //Act
            var fullName = student.GetFullName();

            //Assert
            Assert.Equal("Nome Teste", fullName);
        }
        
        [Fact]
        public void GetAge_ReturnsCorrectAge()
        {
            //Arrange
            var student = new Student();
            student.BirthDate = System.DateTime.Now.AddYears(-20);

            //Act
            var age = student.GetAge();

            //Assert
            Assert.Equal(20, age);
        }
    }
}