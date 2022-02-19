using Xunit;

namespace Questao3
{
    public class Questao3Tests
    {   
        [Fact]
        public void ParesSubstring_RetornaNumeroDeParesDeSustringsQueSaoAnagramas()
        {
          // Arragne
          var s = "ovo";

          // Act 
          var n = Program.ParesSubstring(s);

          // Assert
          Assert.Equal(3, n);
        }
    }
}