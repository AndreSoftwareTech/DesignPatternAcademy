using PadroesCriacao.PatternsCriacao.FactoryMethod.Enums;
using PadroesCriacao.PatternsCriacao.FactoryMethod.Repositories;
using PadroesCriacao.PatternsCriacao.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.FactoryMethod;

public class SelecionaServico : FactoryService
{
    public override IServico FabricarProduto(eTiposServicos tiposservicos)
    {
        switch (tiposservicos)
        {
            case eTiposServicos.tradicional:
                return new TradicionalRepository();
                
            case eTiposServicos.premium: 
                return new PremiumRepository();
                
            case eTiposServicos.master:
                return new MasterRepository();
                
            case eTiposServicos.cobertura:
                return new CoberturaRepository();
                
            default:
                return null;
                
        }

    }
}
