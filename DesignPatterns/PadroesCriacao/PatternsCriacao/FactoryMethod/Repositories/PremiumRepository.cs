using PadroesCriacao.PatternsCriacao.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.FactoryMethod.Repositories;

public class PremiumRepository : IServico
{
    public PremiumRepository()
    {
        Console.WriteLine("Premium");
    }

    public void ExecutaCobranca()
    {

    }
}
