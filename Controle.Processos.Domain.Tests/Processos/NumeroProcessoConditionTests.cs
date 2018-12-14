using System.Collections.Generic;
using System.Linq;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Processos;
using NUnit.Framework;

namespace Controle.Processos.Domain.Tests.Processos
{
    public class NumeroProcessoConditionTests
    {
        private static int NUMERO_PROCESSO = 1;
        private static IList<Processo> _processos = new List<Processo>()
        {
            new Processo() { NumeroProcesso = 1 },
            new Processo() { NumeroProcesso = 2 }
        };
        
        private NumeroProcessoCondition _numeroProcessoCondition;

        [SetUp]
        public void SetUp()
        {
            _numeroProcessoCondition = new NumeroProcessoCondition();
        }

        [Test]
        public void ExpressionFiltraUmaListaDeProcessosPorNumeroDeProcesso()
        {
            var expression = _numeroProcessoCondition.GetExpression(NUMERO_PROCESSO);
            var processosFiltrado = _processos.Where(expression.Compile());

            Assert.That(expression, Is.Not.Null);
            Assert.That(processosFiltrado.Count(), Is.EqualTo(1));
            Assert.That(processosFiltrado.First().NumeroProcesso, Is.EqualTo(NUMERO_PROCESSO));
        }
    }
}