using MeuTeste;

namespace MyTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var resultadoEsperado = "Estou andando";
            var pessoa = new Pessoa();

            // Act
            var resultado = pessoa.Andar();

            // Assert
            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}