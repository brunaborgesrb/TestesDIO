using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImplementação _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementação();
    }

    [Fact] //coloca p saber q é metodo de teste 
    public void Somar4Com9ERetornar13()
    {
        // Arrange - montar o cenario 
        int num1 = 4;
        int num2 = 9;

        // Act - chamar p o que tem q fazer (executar a ação)
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se tem o resultado esperado 
        Assert.Equal(13, resultado);
    }

    public void Subtrair4Com9ERetornarMenos5()
    {
        // Arrange - montar o cenario 
        int num1 = 4;
        int num2 = 9;

        // Act - chamar p o que tem q fazer (executar a ação)
        int resultado = _calc.Subtrair(num1, num2);

        // Assert - validar se tem o resultado esperado 
        Assert.Equal(-5, resultado);
    }

    public void Multiplicar4Com9ERetornar36()
    {
         // Arrange - montar o cenario 
        int num1 = 4;
        int num2 = 9;

        // Act - chamar p o que tem q fazer (executar a ação)
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert - validar se tem o resultado esperado 
        Assert.Equal(36, resultado);
    }

    public void Dividir4Com9ERetornar0()
    {
        // Arrange - montar o cenario 
        int num1 = 4;
        int num2 = 9;

        // Act - chamar p o que tem q fazer (executar a ação)
        int resultado = _calc.Somar(num1, num2);

        // Assert - validar se tem o resultado esperado 
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void VerificarSeEParERetornarVerdadeiro()
    {
        // Arrange - montar o cenario 
        int num = 4;

        // Act - chamar p o que tem q fazer (executar a ação)
        bool resultado = _calc.EhPar(num);
    
        // Assert - validar se tem o resultado esperado
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void VerificarSeOsNumerosSaoParesERetornarVerdadeiros(int numero)
    {
        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert 
        Assert.True(resultado);
    }
}