using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void Contar3CaracteresEmOlaERetornar3()
        {

        // Arrange - montar o cenario 
        string texto = "olá";

        // Act - chamar p o que tem q fazer (executar a ação)
        int resultado = _validacoes.ContarCaracteres(texto);

        // Assert - validar se tem o resultado esperado 
        Assert.Equal(3, resultado);
    }
        }
    }
