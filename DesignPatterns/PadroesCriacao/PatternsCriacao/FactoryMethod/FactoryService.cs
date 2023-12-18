using PadroesCriacao.PatternsCriacao.FactoryMethod.Enums;
using PadroesCriacao.PatternsCriacao.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesCriacao.PatternsCriacao.FactoryMethod;

public abstract  class FactoryService
{
    public abstract IServico FabricarProduto(eTiposServicos tiposservicos);
}
