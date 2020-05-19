using NUnit.Framework;

namespace Exercicio
{
    public class GeradorAleatoriosTesteDeUnidade
    {
        [Test]
        public void Deve_gerar_numeros()
        {
            // arrange
            var gerador = new Gerador();

            // act
            var numeros = gerador.Gerar();

            // assert
            Assert.IsNotEmpty(numeros);
        }
    }
}