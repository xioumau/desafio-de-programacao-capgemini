
using Xunit;

namespace Questao1
{
    public class Questao1Tests
    {
        [Fact]
        public void PrintarEscada_RetornaTamanho()
        {
            // Arrange
            int n = 6;
            var arr = new string[n];

            // Act // Assert
            Assert.Equal("      ", Program.PrintarEscada(n, arr));       
        }
    }
}



