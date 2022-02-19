using Xunit;

namespace Questao2
{
    public class Questao2Tests
    {   
        [Fact]
        public void SenhaValida_RetornaTrue()
        {
            // Arrange
            var senha = "Ya3&ab";

            // Act 
            var result = Program.SenhaValida(ref senha);

            // Assert
            Assert.True(result);
        }
    }
}