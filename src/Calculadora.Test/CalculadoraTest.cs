using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Deveria_somar_dois_valores_Validos()
        {
            Calculadora calculadora = new Calculadora();
            var soma = calculadora.soma(1, 2);

            Assert.IsTrue(soma == 3);
        }

        [TestMethod]
        public void Deveria_subtrair_dois_valores()
        {
            Calculadora calculadora = new Calculadora();
            var subtracao = calculadora.subtracao(5, 2);

            Assert.IsTrue(subtracao == 3);
        }

        [TestMethod]
        public void Deveria_dividir_dois_valores()
        {
            Calculadora calculadora = new Calculadora();
            var divisao = calculadora.divisao(6,2);

            Assert.IsTrue(divisao == 3);
        }

        [TestMethod]
        public void Deveria_lancar_uma_excecao_indicando_falha_ao_dividir_um_numero_por_zero() 
        {
            try
            {
                Calculadora calculadora = new Calculadora();
                var divisao = calculadora.divisao(6, 0);
                Assert.Fail("Não é possível dividir um número por zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não é possível dividir um número por zero \nException: "+ e.Message);
            }

        }

        [TestMethod]
        public void Deveria_multiplicar_dois_valores()
        {
            Calculadora calculadora = new Calculadora();
            var divisao = calculadora.multiplicacao(1, 5);

            Assert.IsTrue(divisao == 5);
        }

    }
}
