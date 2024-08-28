using PasswordGuidelines;
using System.ComponentModel;
using System.Reflection;

namespace PasswordLab
{
    public class UnitTest1
    {
        //[Fact]
        
        [Theory]
        [InlineData("admin", true)]
        [InlineData("HEllo WOr1d", false)]
        [InlineData("password", false)]
        [InlineData("B6mUOj1", false)]
        [InlineData("mod", false)]

        public void PasswordRequirements(string pass, bool expected)
        {
            List<string> passwords = new List<string>()
            {
                "mod",
            };

            //Arrange
            Methods sut = new Methods();
            //Act
            bool result = Methods.AddPassword(pass, passwords);
            //Assert
            Assert.Equal(expected, result);

        }
    }
}