using PadroesCriacao.PatternsCriacao.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.FactoryMethod.Repositories
{
    public class CoberturaRepository : IServico
    {
        public CoberturaRepository()
        {
            Console.WriteLine("Cobertura");
        }

        public void ExecutaCobranca()
        {

        }
    }
}
