using Bonjour42.CICD.Api.Services;

namespace Bonjour42.CICD.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Addition_DeuxNombresPositifs_RetourneLaBonneSomme()
        {
            // Arrange
            MathService math = new MathService();

            // Act
            int resultat = math.Addition(40, 2);

            // Assert
            Assert.Equal(42, resultat);
        }

        [Fact]
        public void Addition_AvecZero_RetourneLeMemeNombre()
        {
            MathService math = new MathService();

            int resultat = math.Addition(5, 0);

            Assert.Equal(5, resultat);
        }

        [Fact]
        public void Addition_DeuxNombresNegatifs_RetourneSommeNegative()
        {
            MathService math = new MathService();

            int resultat = math.Addition(-3, -7);

            Assert.Equal(-10, resultat);
        }
    }
}
